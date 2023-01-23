using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshsTextToSpeechReader.MenuItems
{
    public partial class FrmImportFromWebsite : Form
    {
        public string WebsiteData { get; set; }
        public delegate void ImportFromWebsite();
        public static event ImportFromWebsite FromWebsite;
        
        MenuMethods menuMethods = new MenuMethods();
        

        public FrmImportFromWebsite()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtURL == null)
            {
                this.Close();
            } 
            else
            {
                try
                {
                    string downloadString = "";

                    using (WebClient client = new WebClient())
                    {
                        downloadString = client.DownloadString(txtURL.Text);
                    }
                    
                    WebsiteData = menuMethods.FilterHTML(downloadString);
                    FromWebsite();
                    this.Close();
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
