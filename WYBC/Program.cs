using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
namespace WYBC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool status = true;
            status = checkServerConnection();
            if (status == false)
            {
                MessageBox.Show("Can't connect to Server", "Connection Error");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
          
        }
        /*
        Check server connection
       */
        public static bool checkServerConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://flowerxx.net"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
