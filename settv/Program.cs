using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CrawlerLib.Net;
using System.Security;
using System.Security.Permissions;

namespace settv
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            FileIOPermission writePermission = new FileIOPermission(FileIOPermissionAccess.Write, AppConst.BASE_PATH);
            if (!SecurityManager.IsGranted(writePermission))
            {
                MessageBox.Show("Please run this software by administrator permission");
                return;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string email = Utility.ReadAppRegistry("settv", "ru_email");
            string key = Utility.ReadAppRegistry("settv", "ru_key");
            if (Register.RegisterUser(email, key) == false)
            {

                DialogResult trial_running = MessageBox.Show("Do you want to run trial?", "Saterllite TV Trial", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (trial_running == DialogResult.Yes)
                    Application.Run(new MainApp());
                else
                    Application.Run(new RegisterForm());
            }
            else
                Application.Run(new MainApp());
        }
    }
}
