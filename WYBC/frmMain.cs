using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace WYBC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
           
            InitializeComponent();
            hideElement();
            
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }
        /*
        Hide Element
        */
        public void hideElement()
        {
            lblMsg.Hide();
            txtUser.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yes or no", "Dou you want to exit ?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        /*
       Auth account
       */
        private async void btnYtb_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {

                String aurl = "http://flowerxx.net/wc/index.php?uid="+txtUser.Text+"&pwd="+txtPIN.Text;
                String json = await httpClient.GetStringAsync(aurl);
               // JObject jsObj = JObject.Parse(json);
               
                if (json.ToString()=="0")
                {
                    frmHome fHome = new frmHome();
                    fHome.Show();
                    this.Hide();
                }
                else
                {                    
                    lblMsg.Text = wlang.login_error_msg;
                    lblMsg.Show();
                }
               
            }

        }

    }
}
