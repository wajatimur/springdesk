using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Web;
using Newtonsoft.Json.Linq;

namespace SpringDesk
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void linkLabelAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Globals.springPadObject == null)
            {
                Springpad springPad = new Springpad();
                Globals.springPadObject = springPad;
            }
            else
            {
                if (Globals.springPadObject.AccessToken != null)
                {
                    MessageBox.Show("User is authorized!");
                    return;
                }
            }

            // Load & diplay a modal dialog
            FrmAuth formAuth = new FrmAuth();
            formAuth.ShowDialog();

            // Check if access token is acquire
            if (Globals.springPadObject.AccessToken != null)
            {
                this.Text = Globals.springPadObject.AccessToken.Token;
                linkLabelAuth.Text = "Authorized";
                linkLabelAuth.LinkColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //String data = Globals.springPadObject.WebGetAsString("/users/me/blocks?type=workbook");
            //MessageBox.Show(data);
            JObject dataJson = Globals.springPadObject.WebGetAsJson("/users/me/blocks?type=workbook");
            IList<String> workBooks = dataJson["uuid"].Select(t => (string)t).ToList();

        }


    }

}
