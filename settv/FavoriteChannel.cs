using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CrawlerLib.Net;

namespace settv
{
    class FavoriteChannel
    {
        public static List<Channel> LoadFromFile()
        {
            List<Channel> result = new List<Channel>();
            if (File.Exists(AppConst.BASE_PATH + "favorites.xml") == false)
            {
                Utility.WriteFile(AppConst.BASE_PATH + "favorites.xml", "", false);
            }
            FileStream ReadFileStream = new FileStream(AppConst.BASE_PATH + "favorites.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            System.Xml.Serialization.XmlSerializer x;
            x = new System.Xml.Serialization.XmlSerializer(result.GetType());
            try
            {
                result = (List<Channel>)x.Deserialize(ReadFileStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No fav available");
            }
            ReadFileStream.Close();
            return result;
        }

        public static void SaveToFile(List<Channel> channels)
        {
            if (File.Exists(AppConst.BASE_PATH + "favorites.xml") == false)
            {
                Utility.WriteFile(AppConst.BASE_PATH + "favorites.xml", "", false);
            }
            System.Xml.Serialization.XmlSerializer x;
            x = new System.Xml.Serialization.XmlSerializer(channels.GetType());
            TextWriter WriteFileStream = new StreamWriter(AppConst.BASE_PATH + "favorites.xml");
            x.Serialize(WriteFileStream, channels);
            WriteFileStream.Close();
        }

        public static void AddChannel(Channel c)
        {
            List<Channel> channels = LoadFromFile();
            bool is_added = false;
            for (int i = 0; i < channels.Count; i++)
            {
                if (channels[i].channel_id == c.channel_id)
                {
                    return;
                }
            }

            if (is_added == false)
            {
                channels.Add(c);
                SaveToFile(channels);
            }
        }

        public static void DeleteChannel(string id)
        {
            List<Channel> channels = LoadFromFile();
            for (int i = 0; i < channels.Count; i++)
            {
                if (channels[i].channel_id == id)
                {
                    channels.RemoveAt(i);
                    SaveToFile(channels);
                    return;
                }
            }
        }

        public static bool IsInFavList(Channel c)
        {
            List<Channel> channels = LoadFromFile();
            for (int i = 0; i < channels.Count; i++)
            {
                if (channels[i].channel_id == c.channel_id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
