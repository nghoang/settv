using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using STVControls;
using System.IO;

namespace settv
{
    public delegate void DeCallback();
    public delegate void DeCallbackCountryList(List<Country> list);
    public delegate void DeCallbackCategoryList(List<Category> list);
    public delegate void DeCallbackChannelList(List<Channel> list);

    public partial class MainApp : STVForm, IServerRequest, IRegister, IFlashing
    {
        ServerRequest server = new ServerRequest();
        List<Category> categories = new List<Category>();
        List<Country> countries = new List<Country>();
        List<Channel> channels = new List<Channel>();
        Channel lastest_channel = null;
        bool is_get_category = false;
        bool is_get_country = false;

        //youtube filter data
        string[] category_names = new string[] { "All", "Music", "Entertainment", "Film & Animation", "Comedy" };
        string[] category_ids = new string[] { "", "10", "24", "1", "23" };

        string[] sort_names = new string[] { "Relevance", "Upload date", "View count", "Rating" };
        string[] sort_ids = new string[] { "", "video_date_uploaded", "video_view_count", "video_avg_rating" };

        string[] uploaded_names = new string[] { "Anytime", "Today", "This week", "This month" };
        string[] uploaded_ids = new string[] { "", "d", "w", "m" };
      //  imageList1 = new ImageList();

        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            //create data forlder
            if (!Directory.Exists(AppConst.BASE_PATH))
                Directory.CreateDirectory(AppConst.BASE_PATH);

            //show flashing form
            FlashingForm flashing = new FlashingForm();
            flashing.callback = this;
            flashing.Show();

            labelChannelName.Text = "";

            panelClips.Width = panelStream.Width;

            //we dock video player objects to player panel. so we won't need to manage each object location separately but player panel.
            panel_player.Controls.Add(player_vlc);
            panel_player.Controls.Add(player_wmp);
            panel_player.Controls.Add(player_flash);
            panel_player.Controls.Add(player_web);
            player_vlc.Size = panel_player.Size;
            player_wmp.Size = panel_player.Size;
            player_flash.Size = panel_player.Size;
            player_web.Size = panel_player.Size;
            player_vlc.Dock = DockStyle.Fill;
            player_wmp.Dock = DockStyle.Fill;
            player_flash.Dock = DockStyle.Fill;
            player_web.Dock = DockStyle.Fill;

            //add youtube search control to search box
            groupBoxSearch.Controls.Add(panelClips);
            panelClips.Top = panelStream.Top;
            panelClips.Left = panelStream.Left;

            //initial server object callback is this main class
            server.callback = this;

            InitialLoading();

            //set version for this form
            this.Text = labelVersion.Text + " " + AppConst.VERSION;

            //add trial text if it is trial version
            if (Register.session_id == "")
            {
                this.Text += " - Trial Version";
            }

            LoadYoutubeFilter();

            if (Register.session_id == "")
                SearchForTrialChannel();
            else
            {
                label8.Visible = false;
                stvButtonRegisterNow.Visible = false;
            }

            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet1);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet2);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet3);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet4);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet5);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet6);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet7);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet8);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet9);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet10);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet11);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet12);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet13);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet14);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet15);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet16);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet17);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet18);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet19);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet20);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet10);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet11);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet12);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet13);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet14);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet15);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet16);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet17);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet18);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet19);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet20);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet18);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet19);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet20);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet13);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet14);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet15);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet16);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet17);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet18);
            this.imageList1.Images.Add(global::settv.Properties.Resources.bullet19);
        }

        private void LoadYoutubeFilter()
        {
            foreach (string c in category_names)
            {
                comboBoxYoutubeCategory.Items.Add(c);
            }
            foreach (string c in sort_names)
            {
                comboBoxYoutubeSortBy.Items.Add(c);
            }
            foreach (string c in uploaded_names)
            {
                comboBoxYoutubeUploaded.Items.Add(c);
            }
            comboBoxYoutubeCategory.SelectedIndex = 0;
            comboBoxYoutubeSortBy.SelectedIndex = 0;
            comboBoxYoutubeUploaded.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Register.session_id == "")
            {
                MessageBox.Show("You only can play trial channels from the list", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SearchQuery();
        }

        private void SearchQuery()
        {
            buttonSearch.Enabled = false;
            buttonSearch.Text = "Searching...";
            if (checkBoxClips.Checked)
            {
                server.seaching_keyword = textBoxKeyword.Text;
                server.youtube_cate_id = category_ids[comboBoxYoutubeCategory.SelectedIndex];
                server.youtube_sort_id = sort_ids[comboBoxYoutubeSortBy.SelectedIndex];
                server.youtube_uploaded_id = uploaded_ids[comboBoxYoutubeUploaded.SelectedIndex];
                server.youtube_max_page = 3;
                Thread th = new Thread(new ThreadStart(server.GetYoutube));
                th.Start();
            }
            else
            {
                server.seaching_keyword = textBoxKeyword.Text;
                server.seaching_catagory = categories[comboBoxCategory.SelectedIndex].id;
                server.seaching_country = countries[comboBoxCountry.SelectedIndex].id;
                Thread th = new Thread(new ThreadStart(server.GetChannel));
                th.Start();
            }
        }

        private void SearchForTrialChannel()
        {
            server.search_trial = true;
            Thread th = new Thread(new ThreadStart(server.GetChannel));
            th.Start();
        }

        private void InitialLoading()
        {
            Thread th = new Thread(new ThreadStart(server.GetCountries));
            th.Start();

            th = new Thread(new ThreadStart(server.GetCategories));
            th.Start();
        }

        public void FinishedLoadCategory(List<Category> list)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DeCallbackCategoryList(FinishedLoadCategory), list);
                return;
            }

            //adding All to search in all category
            Category all = new Category();
            all.id = 0;
            all.name = "All";
            list.Insert(0, all);

            //adding a favorite category, this is kind of special category. 
            Category fav = new Category();
            fav.id = -1;
            fav.name = "Favorites";
            list.Insert(1, fav);

            comboBoxCategory.Items.Clear();
            categories.Clear();
            foreach (Category i in list)
            {
                categories.Add(i);
                comboBoxCategory.Items.Add(i.name);
            }
            comboBoxCategory.SelectedIndex = 0;
            is_get_category = true;
            EnableSearch();
        }

        private void EnableSearch()
        {
            if (is_get_category == true && is_get_country == true)
            {
                buttonSearch.Enabled = true;
            }
        }

        public void FinishedLoadCountry(List<Country> list)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DeCallbackCountryList(FinishedLoadCountry), list);
                return;
            }

            //add All to search in all countries
            Country all = new Country();
            all.id = 0;
            all.name = "All";
            list.Insert(0, all);

            comboBoxCountry.Items.Clear();
            countries.Clear();
            foreach (Country i in list)
            {
                countries.Add(i);
                comboBoxCountry.Items.Add(i.name);
            }
            comboBoxCountry.SelectedIndex = 0;
            is_get_country = true;
            EnableSearch();
        }

        public void FinishedLoadChannel(List<Channel> list)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DeCallbackChannelList(FinishedLoadChannel), list);
                return;
            }
            listBoxChannel.Items.Clear();
            channels.Clear();
            listBoxChannel.ImageList = imageList1;
            int a = 0;
            foreach (Channel i in list)
            {
                channels.Add(i);
                listBoxChannel.Items.Add(new GListBoxItem(i.channel_name, a));
                a++;
            }
            buttonSearch.Enabled = true;
            buttonSearch.Text = "Search";
        }

        private void PlayChannel(Channel c)
        {
            lastest_channel = c;
            labelChannelName.Text = c.channel_name;
            //we cannot add youtube as fav channel
            if (c.is_youtube == true)
            {
                buttonAddFavorite.Enabled = false;
            }
            else
            {
                buttonAddFavorite.Visible = true;
                //check to show fav button status
                if (FavoriteChannel.IsInFavList(c) == true)
                {
                    buttonAddFavorite.BackgroundImage = global::settv.Properties.Resources.add_to_fav_bttn_active;
                }
                else
                {
                    buttonAddFavorite.BackgroundImage = global::settv.Properties.Resources.add_to_fav_bttn1;
                }
            }

            //check video type to play
            Console.WriteLine("Play Channel: (" + c.channel_name + ") " + c.channel_url);
            player_flash.Visible = false;
            player_wmp.Visible = false;
            player_web.Visible = false;
            player_vlc.Visible = false;
            StopChannel();
            if (c.channel_type == "flash")
            {
                player_flash.Visible = true;
                player_flash.Movie = c.channel_url;
                player_flash.Play();
            }
            else if (c.channel_type == "web")
            {
                player_web.Visible = true;
                player_web.Url = new Uri(c.channel_url);
            }
            else if (c.channel_type == "vlc")
            {
                //player_vlc.playlist.items.clear();
                //string[] options = { ":vout-filter=deinterlace", ":deinterlace-mode=linear" };
                //player_vlc.playlist.add("http://www.mediacollege.com/video-gallery/testclips/barsandtone.flv", "", options);
                //player_vlc.playlist.playItem(0);
                player_vlc.Visible = true;
                player_vlc.addTarget(c.channel_url, null, AXVLC.VLCPlaylistMode.VLCPlayListReplace, 0);
                player_vlc.play();
            }
            else if (c.channel_type == "wmp")
            {
                //hide all control on windows media player
                player_wmp.Visible = true;
                if (c.is_youtube == true)
                {
                    string youtube_streaming = YoutubeObject.GetYoutubeStreamingURL(c.channel_url);
                    player_wmp.URL = youtube_streaming;
                }
                else
                {
                    player_wmp.URL = c.channel_url;
                }
                player_wmp.Ctlcontrols.play();
                player_wmp.uiMode = "none";
                player_wmp.stretchToFit = true;
            }
            buttonPlay.BackgroundImage = global::settv.Properties.Resources.play_bttn_active;
        }

        private void StopChannel()
        {
            try
            {
                player_web.Url = new Uri("about:blank");
                player_wmp.URL = "";
                player_wmp.Ctlcontrols.stop();
                player_flash.Movie = "http://";
                player_vlc.stop();
            }
            catch (Exception ex)
            {
                buttonPlay.BackgroundImage = global::settv.Properties.Resources.play_bttn_normal;
            }
            //buttonPlay.Text = "Stop";
            buttonPlay.BackgroundImage = global::settv.Properties.Resources.play_bttn_normal;
        }

        private void listBoxChannel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlayChannel(channels[listBoxChannel.SelectedIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lastest_channel == null)
            {
                if (listBoxChannel.SelectedIndex != -1)
                {
                    PlayChannel(channels[listBoxChannel.SelectedIndex]);
                }
                else
                {
                    MessageBox.Show("Please choose a channel to play");
                    return;
                }
            }
            else
            {
                PlayChannel(lastest_channel);
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                player_wmp.settings.volume = trackBar1.Value;
                player_vlc.Volume = trackBar1.Value;
            }
            catch
            {}
        }

        private void textBoxKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SearchQuery();
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if seletect the favorite category, we load from fav file instead loading from server. 
            //and we also disable search from server to prevent loading from server
            if (categories[comboBoxCategory.SelectedIndex].id == -1)
            {
                buttonSearch.Enabled = false;

                //load channels from fav file
                List<Channel> new_channels = FavoriteChannel.LoadFromFile();
                FinishedLoadChannel(new_channels);
            }
            else
            {
                buttonSearch.Enabled = true;
            }
        }

        private void buttonAddFavorite_Click(object sender, EventArgs e)
        {
            if (lastest_channel == null)
            {
                MessageBox.Show("There is not selected channel");
                return;
            }
            if (FavoriteChannel.IsInFavList(lastest_channel) == true)
            {
                FavoriteChannel.DeleteChannel(lastest_channel.channel_id);
                buttonAddFavorite.BackgroundImage = global::settv.Properties.Resources.add_to_fav_bttn1;
            }
            else
            {
                FavoriteChannel.AddChannel(lastest_channel);
                buttonAddFavorite.BackgroundImage = global::settv.Properties.Resources.add_to_fav_bttn_active;
            }

            FinishedLoadChannel(FavoriteChannel.LoadFromFile());
        }

        private void deleteThisChannelFromTheListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxChannel.SelectedIndex == -1)
                return;
            if (categories[comboBoxCategory.SelectedIndex].id == -1) //if favorite cateogory
            {
                FavoriteChannel.DeleteChannel(channels[listBoxChannel.SelectedIndex].channel_id);
            }
            channels.RemoveAt(listBoxChannel.SelectedIndex);
            listBoxChannel.Items.RemoveAt(listBoxChannel.SelectedIndex);
        }

        private void checkBoxClips_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClips.Checked)
            {
                panelStream.Visible = false;
                panelClips.Visible = true;
            }
            else
            {
                panelStream.Visible = true;
                panelClips.Visible = false;
            }
        }

        public void FinishedSearchingYoutube(List<YoutubeObject> list)
        {
            throw new NotImplementedException();
        }

        private void timerValidate_Tick(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.callback = this;
            Thread th = new Thread(new ThreadStart(reg.ValidateUser));
            th.Start();
        }

        public void ValidateUserFailed()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DeCallback(ValidateUserFailed));
                return;
            }
            MessageBox.Show("This account is using by another user.", "Validating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void labelVersion_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void label8_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Register.session_id == "")
            {
                MessageBox.Show("You only can play trial channels from the list", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SearchQuery();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }


        private void stvButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void stvButton2_Click(object sender, EventArgs e)
        {
            StopChannel();
        }

        private void MainApp_Resize(object sender, EventArgs e)
        {
            pictureBox12.Size = new Size(this.Width - 280, 115);
            label8.Top = this.Height - 67;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.satellitetvstream.com");
        }

        public void FinishedFlashing()
        {
            //this.Visible = true;
        }
    }
}
