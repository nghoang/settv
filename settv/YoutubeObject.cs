using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrawlerLib.Net;

namespace settv
{
    public class YoutubeObject
    {
        public string youtube_url = "";
        public string image = "";
        public string author = "";
        public string author_url = "";
        public string view_count = "";
        public string has_uploaded_date = "";
        public string description = "";
        public string title = "";
        public string time = "";

        internal static string GetYoutubeStreamingURL(string youtubeid)
        {
            WebclientX client = new WebclientX();
            youtubeid = Utility.SimpleRegexSingle("v=([0-9a-zA-Z_-]*)", youtubeid, 1);
            string youtubeinfo = client.GetMethod("http://www.youtube.com/get_video_info?video_id=" + youtubeid);
            if (youtubeinfo.IndexOf("errorcode=150") > 0)
            {
                youtubeinfo = client.GetMethod("http://www.youtube.com/watch?v=" + youtubeid);
                youtubeinfo = Utility.SimpleRegexSingle("flashvars=\"([^\"]*)\"", youtubeinfo, 1);
            }
            string content = Utility.SimpleRegexSingle("fmt_stream_map=([^&]+)", youtubeinfo, 1);
            content = Utility.URLDecode(content);
            List<string> video_links = Utility.SimpleRegex(@"url=.*?(?=type=)[^,]*", content, 0);
            string youtube_mp4_file = "";
            foreach (string vl in video_links)
            {
                if (vl.IndexOf("video%2Fmp4") > 0)
                {
                    youtube_mp4_file = Utility.URLDecode(Utility.SimpleRegexSingle("url=([^&]*)", vl, 1));
                }
            }

            return youtube_mp4_file;
        }
    }
}
