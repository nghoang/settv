using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrawlerLib.Net;
using System.Collections.Specialized;

namespace settv
{
    class Register
    {
        public IRegister callback;
        public static string session_id = "";

        public static bool RegisterUser(string email, string key)
        {
            WebclientX client = new WebclientX();
            if (email == "" || key == "")
            {
                return false;
                //return true;//testing
            }
            NameValueCollection ps = new NameValueCollection();
            ps.Add("email", email);
            ps.Add("key", key);
            string content = client.PostMethod(AppConst.SERVER_ADDRESS + "/register", ps);
            string temp_session_id = content.Trim();
            if (temp_session_id == "" || temp_session_id.Length != 15)
            {
                Utility.WriteAppRegistry("settv", "ru_email", "");
                Utility.WriteAppRegistry("settv", "ru_key", "");
                return false;
            }
            session_id = temp_session_id;
            Utility.WriteAppRegistry("settv", "ru_email", email);
            Utility.WriteAppRegistry("settv", "ru_key", key);
            return true;
        }

        public void ValidateUser()
        {
            WebclientX client = new WebclientX();
            NameValueCollection ps = new NameValueCollection();
            ps.Add("session_id", session_id);
            string content = client.PostMethod(AppConst.SERVER_ADDRESS + "/validate", ps);
            if (content.Trim() != "1")
                callback.ValidateUserFailed();
        }
    }
}
