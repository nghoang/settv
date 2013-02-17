using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace settv
{
    class AppConst
    {
        public static string SERVER_ADDRESS = "http://satellite-live-tv.com/server/index.php/set_tv";
        public static string VERSION = "1.2.11";
        public static string BASE_PATH = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "\\sattv-data\\";
    }
}
