using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;
using CrawlerLib.Net;

namespace settv
{
    class ServerRequest
    {
        public IServerRequest callback;

        public string seaching_keyword;
        public int seaching_catagory;
        public int seaching_country;

        public string youtube_cate_id;
        public string youtube_sort_id;
        public string youtube_uploaded_id;
        public int youtube_max_page;
        public bool search_trial = false;

        public void GetYoutube()
        {
            List<Channel> list = new List<Channel>();
            WebclientX client = new WebclientX();
            string category = "";
            string sort = "";
            string uploaded = "";
            if (uploaded != "")
            {
                category = "search_category=" + uploaded + "&";
            }
            if (youtube_sort_id != "")
            {
                sort = "search_sort=" + youtube_sort_id + "&";
            }
            if (youtube_uploaded_id != "")
            {
                uploaded = "uploaded=" + youtube_uploaded_id + "&";
            }

            string search_link = "http://www.youtube.com/results?" + sort + uploaded + category + "search_query=" + Utility.URLEncode(seaching_keyword) + "&page=";

            for (int i = 1; i <= youtube_max_page; i++)
            {
                string search_content = client.GetMethod(search_link + i);
                List<Channel> items = GetListYoutubeVD(search_content);
                list.AddRange(items);
            }
            callback.FinishedLoadChannel(list);
        }

        public static List<Channel> GetListYoutubeVD(string content)
        {
            List<Channel> res = new List<Channel>();
            List<string> result_blocks = Utility.SimpleRegex(@"<li class=""yt-grid-box.*?(?=</li>)</li>", content, 0);
            foreach (string block in result_blocks)
            {
                Channel item = new Channel();
                item.channel_image = Utility.SimpleRegexSingle(@"<img src=""//([^""]*)"" alt=""Thumbnail""", block, 1);
                item.channel_image = item.channel_image.Replace("http://", "");
                item.description = Utility.SimpleRegexSingle(@"<p class=""description.*?(?=>)>(.*?)(?=</p>)</p>", block, 1);
                item.channel_url = Utility.SimpleRegexSingle(@"href=""(/watch\?v=[^""]*)""", block, 1);
                item.channel_name = Utility.SimpleRegexSingle(@">([^<]*)</a></h3>", block, 1);

                item.channel_id = item.channel_url;
                item.channel_type = "wmp";
                item.is_youtube = true;
                if (item.channel_name.Trim() == "")
                    continue;
                res.Add(item);
            }
            return res;
        }

        public void GetCategories()
        {
            List<Category> list = new List<Category>();

            WebClient client = new WebClient();
            string content = client.DownloadString(AppConst.SERVER_ADDRESS + "/get_category");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(content);
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("category");
            foreach (XmlNode node in nodeList)
            {
                Category item = new Category();
                item.id = int.Parse(node.Attributes["id"].Value);
                item.name = Utility.URLDecode(node.Attributes["name"].Value);
                list.Add(item);
            }

            callback.FinishedLoadCategory(list);
        }

        public void GetCountries()
        {
            List<Country> list = new List<Country>();

            WebClient client = new WebClient();
            string content = client.DownloadString(AppConst.SERVER_ADDRESS + "/get_country");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(content);
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("country");
            foreach (XmlNode node in nodeList)
            {
                Country item = new Country();
                item.id = int.Parse(node.Attributes["id"].Value);

                item.name = Utility.URLDecode(node.Attributes["name"].Value);
                list.Add(item);
            }

            callback.FinishedLoadCountry(list);
        }

        public void GetChannel()
        {
            List<Channel> list = new List<Channel>();

            WebClient client = new WebClient();
            string content = "";
            if (search_trial == true)
                content = client.DownloadString(AppConst.SERVER_ADDRESS + "/get_channel?search_trial=1");
            else
                content = client.DownloadString(AppConst.SERVER_ADDRESS + "/get_channel?session_id=" + Register.session_id + "&country=" + seaching_country + "&category=" + seaching_catagory + "&keyword=" + seaching_keyword);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(content);
            XmlNodeList nodeList = xmlDoc.GetElementsByTagName("channel");
            foreach (XmlNode node in nodeList)
            {
                Channel item = new Channel();
                item.channel_id = node.Attributes["channel_id"].Value;
                item.channel_name = Utility.URLDecode(node.Attributes["channel_name"].Value);
                item.channel_url = Utility.URLDecode(node.Attributes["channel_url"].Value);
                item.description = Utility.URLDecode(node.Attributes["description"].Value);
                item.channel_type = node.Attributes["channel_type"].Value;
                list.Add(item);
            }

            callback.FinishedLoadChannel(list);
        }
    }
}
