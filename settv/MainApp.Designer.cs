using STVControls;
namespace settv
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.groupBoxSearch = new STVControls.STVGroup(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelStream = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new STVControls.STVLabel(this.components);
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label4 = new STVControls.STVLabel(this.components);
            this.checkBoxClips = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new STVControls.STVButton(this.components);
            this.label2 = new STVControls.STVLabel(this.components);
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new STVControls.STVGroup(this.components);
            this.listBoxChannel = new settv.ListBoxWithIcons();
            this.contextMenuStripListChannel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteThisChannelFromTheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.player_flash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.player_web = new System.Windows.Forms.WebBrowser();
            this.player_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.player_vlc = new AxAXVLC.AxVLCPlugin();
            this.labelVersion = new STVControls.STVLabel(this.components);
            this.labelChannelName = new STVControls.STVLabel(this.components);
            this.label1 = new STVControls.STVLabel(this.components);
            this.timerValidate = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.stvButton5 = new STVControls.STVButton(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.stvButton4 = new STVControls.STVButton(this.components);
            this.stvButton3 = new STVControls.STVButton(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stvButton2 = new STVControls.STVButton(this.components);
            this.panel_player = new System.Windows.Forms.Panel();
            this.panelClips = new System.Windows.Forms.Panel();
            this.label7 = new STVControls.STVLabel(this.components);
            this.label6 = new STVControls.STVLabel(this.components);
            this.label5 = new STVControls.STVLabel(this.components);
            this.comboBoxYoutubeUploaded = new System.Windows.Forms.ComboBox();
            this.comboBoxYoutubeSortBy = new System.Windows.Forms.ComboBox();
            this.comboBoxYoutubeCategory = new System.Windows.Forms.ComboBox();
            this.stvButtonRegisterNow = new STVControls.STVButton(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonAddFavorite = new STVControls.STVButton(this.components);
            this.buttonPlay = new STVControls.STVButton(this.components);
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelStream.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStripListChannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_flash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_vlc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_player.SuspendLayout();
            this.panelClips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.groupBoxSearch.Controls.Add(this.pictureBox1);
            this.groupBoxSearch.Controls.Add(this.panelStream);
            this.groupBoxSearch.Controls.Add(this.checkBoxClips);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.label2);
            this.groupBoxSearch.Controls.Add(this.textBoxKeyword);
            this.groupBoxSearch.ForeColor = System.Drawing.Color.Red;
            this.groupBoxSearch.Location = new System.Drawing.Point(17, 148);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSearch.Size = new System.Drawing.Size(312, 210);
            this.groupBoxSearch.TabIndex = 1;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::settv.Properties.Resources.search_bttn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(173, 166);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 42);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelStream
            // 
            this.panelStream.Controls.Add(this.comboBoxCategory);
            this.panelStream.Controls.Add(this.label3);
            this.panelStream.Controls.Add(this.comboBoxCountry);
            this.panelStream.Controls.Add(this.label4);
            this.panelStream.Location = new System.Drawing.Point(9, 53);
            this.panelStream.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStream.Name = "panelStream";
            this.panelStream.Size = new System.Drawing.Size(295, 66);
            this.panelStream.TabIndex = 13;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.ForeColor = System.Drawing.Color.Tan;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(107, 2);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(184, 24);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCountry.ForeColor = System.Drawing.Color.Tan;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(107, 34);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(184, 24);
            this.comboBoxCountry.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country";
            // 
            // checkBoxClips
            // 
            this.checkBoxClips.AutoSize = true;
            this.checkBoxClips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxClips.ForeColor = System.Drawing.Color.Tan;
            this.checkBoxClips.Location = new System.Drawing.Point(93, 175);
            this.checkBoxClips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxClips.Name = "checkBoxClips";
            this.checkBoxClips.Size = new System.Drawing.Size(56, 21);
            this.checkBoxClips.TabIndex = 7;
            this.checkBoxClips.Text = "Clips";
            this.checkBoxClips.UseVisualStyleBackColor = true;
            this.checkBoxClips.CheckedChanged += new System.EventHandler(this.checkBoxClips_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Blue;
            this.buttonSearch.BackgroundImage = global::settv.Properties.Resources.search_bttn;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Enabled = false;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(192, 171);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 28);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keyword";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.textBoxKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKeyword.ForeColor = System.Drawing.Color.Tan;
            this.textBoxKeyword.Location = new System.Drawing.Point(116, 21);
            this.textBoxKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(185, 22);
            this.textBoxKeyword.TabIndex = 0;
            this.textBoxKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyword_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.listBoxChannel);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(17, 361);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(315, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channel List";
            // 
            // listBoxChannel
            // 
            this.listBoxChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.listBoxChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxChannel.ContextMenuStrip = this.contextMenuStripListChannel;
            this.listBoxChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxChannel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxChannel.ForeColor = System.Drawing.Color.Tan;
            this.listBoxChannel.FormattingEnabled = true;
            this.listBoxChannel.ImageList = null;
            this.listBoxChannel.Location = new System.Drawing.Point(3, 17);
            this.listBoxChannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxChannel.Name = "listBoxChannel";
            this.listBoxChannel.Size = new System.Drawing.Size(309, 201);
            this.listBoxChannel.TabIndex = 0;
            this.listBoxChannel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxChannel_MouseDoubleClick);
            // 
            // contextMenuStripListChannel
            // 
            this.contextMenuStripListChannel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteThisChannelFromTheListToolStripMenuItem});
            this.contextMenuStripListChannel.Name = "contextMenuStripListChannel";
            this.contextMenuStripListChannel.Size = new System.Drawing.Size(289, 28);
            // 
            // deleteThisChannelFromTheListToolStripMenuItem
            // 
            this.deleteThisChannelFromTheListToolStripMenuItem.Name = "deleteThisChannelFromTheListToolStripMenuItem";
            this.deleteThisChannelFromTheListToolStripMenuItem.Size = new System.Drawing.Size(288, 24);
            this.deleteThisChannelFromTheListToolStripMenuItem.Text = "Delete this channel from the list";
            this.deleteThisChannelFromTheListToolStripMenuItem.Click += new System.EventHandler(this.deleteThisChannelFromTheListToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(955, 593);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(219, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // player_flash
            // 
            this.player_flash.Enabled = true;
            this.player_flash.Location = new System.Drawing.Point(0, 0);
            this.player_flash.Name = "player_flash";
            this.player_flash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player_flash.OcxState")));
            this.player_flash.Size = new System.Drawing.Size(75, 23);
            this.player_flash.TabIndex = 0;
            this.player_flash.Visible = false;
            // 
            // player_web
            // 
            this.player_web.IsWebBrowserContextMenuEnabled = false;
            this.player_web.Location = new System.Drawing.Point(0, 0);
            this.player_web.Name = "player_web";
            this.player_web.ScriptErrorsSuppressed = true;
            this.player_web.Size = new System.Drawing.Size(250, 250);
            this.player_web.TabIndex = 0;
            this.player_web.Visible = false;
            this.player_web.WebBrowserShortcutsEnabled = false;
            // 
            // player_wmp
            // 
            this.player_wmp.Enabled = true;
            this.player_wmp.Location = new System.Drawing.Point(0, 0);
            this.player_wmp.Name = "player_wmp";
            this.player_wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player_wmp.OcxState")));
            this.player_wmp.Size = new System.Drawing.Size(75, 23);
            this.player_wmp.TabIndex = 0;
            this.player_wmp.Visible = false;
            // 
            // player_vlc
            // 
            this.player_vlc.Enabled = true;
            this.player_vlc.Location = new System.Drawing.Point(0, 0);
            this.player_vlc.Name = "player_vlc";
            this.player_vlc.Size = new System.Drawing.Size(75, 23);
            this.player_vlc.TabIndex = 0;
            this.player_vlc.Visible = false;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.Tan;
            this.labelVersion.Location = new System.Drawing.Point(352, 112);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(239, 29);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Satellite TV Stream";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // labelChannelName
            // 
            this.labelChannelName.AutoSize = true;
            this.labelChannelName.BackColor = System.Drawing.Color.Transparent;
            this.labelChannelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelChannelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChannelName.ForeColor = System.Drawing.Color.Tan;
            this.labelChannelName.Location = new System.Drawing.Point(620, 112);
            this.labelChannelName.Name = "labelChannelName";
            this.labelChannelName.Size = new System.Drawing.Size(109, 29);
            this.labelChannelName.TabIndex = 13;
            this.labelChannelName.Text = "Channel";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1061, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Volume";
            // 
            // timerValidate
            // 
            this.timerValidate.Interval = 30000;
            this.timerValidate.Tick += new System.EventHandler(this.timerValidate_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Tan;
            this.label8.Location = new System.Drawing.Point(37, 614);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "To get Full features";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::settv.Properties.Resources.privacy_bttn;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(1055, 15);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(116, 39);
            this.pictureBox8.TabIndex = 39;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::settv.Properties.Resources.products_bttn;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(557, 15);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(125, 39);
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::settv.Properties.Resources.settings_bttn;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(928, 15);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(124, 39);
            this.pictureBox9.TabIndex = 38;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // stvButton5
            // 
            this.stvButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stvButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButton5.BackgroundImage = global::settv.Properties.Resources.prev_bttn;
            this.stvButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stvButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stvButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButton5.Location = new System.Drawing.Point(343, 601);
            this.stvButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stvButton5.Name = "stvButton5";
            this.stvButton5.Size = new System.Drawing.Size(59, 48);
            this.stvButton5.TabIndex = 46;
            this.stvButton5.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::settv.Properties.Resources.list_bttn;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(684, 15);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 39);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::settv.Properties.Resources.features_bttn;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(789, 15);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(136, 39);
            this.pictureBox10.TabIndex = 37;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // stvButton4
            // 
            this.stvButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stvButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButton4.BackgroundImage = global::settv.Properties.Resources.pause_bttn_normal;
            this.stvButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stvButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stvButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButton4.Location = new System.Drawing.Point(400, 601);
            this.stvButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stvButton4.Name = "stvButton4";
            this.stvButton4.Size = new System.Drawing.Size(56, 48);
            this.stvButton4.TabIndex = 45;
            this.stvButton4.UseVisualStyleBackColor = false;
            // 
            // stvButton3
            // 
            this.stvButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stvButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButton3.BackgroundImage = global::settv.Properties.Resources.next_bttn;
            this.stvButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stvButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stvButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButton3.Location = new System.Drawing.Point(571, 601);
            this.stvButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stvButton3.Name = "stvButton3";
            this.stvButton3.Size = new System.Drawing.Size(55, 48);
            this.stvButton3.TabIndex = 44;
            this.stvButton3.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::settv.Properties.Resources.about_bttn;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(451, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 39);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::settv.Properties.Resources.home_bttn;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(343, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 39);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // stvButton2
            // 
            this.stvButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stvButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButton2.BackgroundImage = global::settv.Properties.Resources.stop_bttn_normal;
            this.stvButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stvButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stvButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButton2.Location = new System.Drawing.Point(515, 601);
            this.stvButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stvButton2.Name = "stvButton2";
            this.stvButton2.Size = new System.Drawing.Size(55, 48);
            this.stvButton2.TabIndex = 43;
            this.stvButton2.UseVisualStyleBackColor = false;
            this.stvButton2.Click += new System.EventHandler(this.stvButton2_Click);
            // 
            // panel_player
            // 
            this.panel_player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel_player.BackgroundImage = global::settv.Properties.Resources.right_panel_bg;
            this.panel_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_player.Controls.Add(this.panelClips);
            this.panel_player.Location = new System.Drawing.Point(343, 154);
            this.panel_player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_player.Name = "panel_player";
            this.panel_player.Size = new System.Drawing.Size(829, 427);
            this.panel_player.TabIndex = 11;
            // 
            // panelClips
            // 
            this.panelClips.Controls.Add(this.label7);
            this.panelClips.Controls.Add(this.label6);
            this.panelClips.Controls.Add(this.label5);
            this.panelClips.Controls.Add(this.comboBoxYoutubeUploaded);
            this.panelClips.Controls.Add(this.comboBoxYoutubeSortBy);
            this.panelClips.Controls.Add(this.comboBoxYoutubeCategory);
            this.panelClips.Location = new System.Drawing.Point(283, 319);
            this.panelClips.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClips.Name = "panelClips";
            this.panelClips.Size = new System.Drawing.Size(296, 121);
            this.panelClips.TabIndex = 13;
            this.panelClips.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Tan;
            this.label7.Location = new System.Drawing.Point(11, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Uploaded";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(11, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sort By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(11, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category";
            // 
            // comboBoxYoutubeUploaded
            // 
            this.comboBoxYoutubeUploaded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxYoutubeUploaded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.comboBoxYoutubeUploaded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYoutubeUploaded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYoutubeUploaded.ForeColor = System.Drawing.Color.Tan;
            this.comboBoxYoutubeUploaded.FormattingEnabled = true;
            this.comboBoxYoutubeUploaded.Location = new System.Drawing.Point(105, 79);
            this.comboBoxYoutubeUploaded.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxYoutubeUploaded.Name = "comboBoxYoutubeUploaded";
            this.comboBoxYoutubeUploaded.Size = new System.Drawing.Size(185, 24);
            this.comboBoxYoutubeUploaded.TabIndex = 16;
            // 
            // comboBoxYoutubeSortBy
            // 
            this.comboBoxYoutubeSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxYoutubeSortBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.comboBoxYoutubeSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYoutubeSortBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYoutubeSortBy.ForeColor = System.Drawing.Color.Tan;
            this.comboBoxYoutubeSortBy.FormattingEnabled = true;
            this.comboBoxYoutubeSortBy.Location = new System.Drawing.Point(105, 42);
            this.comboBoxYoutubeSortBy.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxYoutubeSortBy.Name = "comboBoxYoutubeSortBy";
            this.comboBoxYoutubeSortBy.Size = new System.Drawing.Size(185, 24);
            this.comboBoxYoutubeSortBy.TabIndex = 15;
            // 
            // comboBoxYoutubeCategory
            // 
            this.comboBoxYoutubeCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxYoutubeCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.comboBoxYoutubeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYoutubeCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxYoutubeCategory.ForeColor = System.Drawing.Color.Tan;
            this.comboBoxYoutubeCategory.FormattingEnabled = true;
            this.comboBoxYoutubeCategory.Location = new System.Drawing.Point(105, 4);
            this.comboBoxYoutubeCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxYoutubeCategory.Name = "comboBoxYoutubeCategory";
            this.comboBoxYoutubeCategory.Size = new System.Drawing.Size(184, 24);
            this.comboBoxYoutubeCategory.TabIndex = 14;
            // 
            // stvButtonRegisterNow
            // 
            this.stvButtonRegisterNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stvButtonRegisterNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.stvButtonRegisterNow.BackgroundImage = global::settv.Properties.Resources.register_now_bttn;
            this.stvButtonRegisterNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stvButtonRegisterNow.Cursor = System.Windows.Forms.Cursors.Default;
            this.stvButtonRegisterNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stvButtonRegisterNow.ForeColor = System.Drawing.Color.Transparent;
            this.stvButtonRegisterNow.Location = new System.Drawing.Point(175, 603);
            this.stvButtonRegisterNow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stvButtonRegisterNow.Name = "stvButtonRegisterNow";
            this.stvButtonRegisterNow.Size = new System.Drawing.Size(137, 39);
            this.stvButtonRegisterNow.TabIndex = 42;
            this.stvButtonRegisterNow.UseVisualStyleBackColor = false;
            this.stvButtonRegisterNow.Click += new System.EventHandler(this.stvButton1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::settv.Properties.Resources.logo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(17, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(312, 127);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // buttonAddFavorite
            // 
            this.buttonAddFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonAddFavorite.BackgroundImage = global::settv.Properties.Resources.add_to_fav_bttn1;
            this.buttonAddFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonAddFavorite.Location = new System.Drawing.Point(676, 601);
            this.buttonAddFavorite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddFavorite.Name = "buttonAddFavorite";
            this.buttonAddFavorite.Size = new System.Drawing.Size(61, 48);
            this.buttonAddFavorite.TabIndex = 12;
            this.buttonAddFavorite.UseVisualStyleBackColor = false;
            this.buttonAddFavorite.Visible = false;
            this.buttonAddFavorite.Click += new System.EventHandler(this.buttonAddFavorite_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonPlay.BackgroundImage = global::settv.Properties.Resources.play_bttn_normal;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.buttonPlay.Location = new System.Drawing.Point(455, 601);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(61, 48);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackgroundImage = global::settv.Properties.Resources.header_bg;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(344, 15);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(832, 133);
            this.pictureBox12.TabIndex = 47;
            this.pictureBox12.TabStop = false;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1189, 655);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.labelChannelName);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.stvButton5);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.stvButton4);
            this.Controls.Add(this.stvButton3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.stvButton2);
            this.Controls.Add(this.panel_player);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.stvButtonRegisterNow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonAddFavorite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.pictureBox12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.Resize += new System.EventHandler(this.MainApp_Resize);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelStream.ResumeLayout(false);
            this.panelStream.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStripListChannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_flash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_vlc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_player.ResumeLayout(false);
            this.panelClips.ResumeLayout(false);
            this.panelClips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private STVGroup groupBoxSearch;
        private STVButton buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private STVLabel label4;
        private STVLabel label3;
        private STVLabel label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private STVGroup groupBox2;
        private ListBoxWithIcons listBoxChannel;
        private STVButton buttonPlay;
        private System.Windows.Forms.TrackBar trackBar1;
        private AxShockwaveFlashObjects.AxShockwaveFlash player_flash;
        private System.Windows.Forms.WebBrowser player_web;
        private AxWMPLib.AxWindowsMediaPlayer player_wmp;
        private AxAXVLC.AxVLCPlugin player_vlc;
        private System.Windows.Forms.Panel panel_player;
        private STVButton buttonAddFavorite;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListChannel;
        private System.Windows.Forms.ToolStripMenuItem deleteThisChannelFromTheListToolStripMenuItem;
        private STVLabel label1;
        private System.Windows.Forms.CheckBox checkBoxClips;
        private System.Windows.Forms.Panel panelStream;
        private System.Windows.Forms.Panel panelClips;
        private STVLabel label5;
        private System.Windows.Forms.ComboBox comboBoxYoutubeUploaded;
        private System.Windows.Forms.ComboBox comboBoxYoutubeSortBy;
        private System.Windows.Forms.ComboBox comboBoxYoutubeCategory;
        private STVLabel label7;
        private STVLabel label6;
        private STVLabel labelChannelName;
        private System.Windows.Forms.Timer timerValidate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private STVLabel labelVersion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private STVButton stvButtonRegisterNow;
        private STVButton stvButton2;
        private STVButton stvButton3;
        private STVButton stvButton4;
        private STVButton stvButton5;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label8;
    }
}

