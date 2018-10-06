using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anonemail
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void BClose_Click(object sender, EventArgs e) { this.Hide(); }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            LVersion.Text = "Version: " + Application.ProductVersion;
        }

        private void BCheckupdate_Click(object sender, EventArgs e)
        {

    

            // Create web client simulating IE6.
            using (WebClient client = new WebClient())
            {
                client.Headers["User-Agent"] =
                    "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                    "(compatible; MSIE 6.0; Windows NT 5.1; " +
                    ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

                // Download data.
                byte[] arr = client.DownloadData("https://habby1337.github.io/anonmail/version.txt");

                // Write values.
                Console.WriteLine("--- WebClient result ---");
                Console.WriteLine(arr.Length);
                // Parse the returned data (if any) if needed.
                var responseString = Encoding.UTF8.GetString(arr);

                if (Convert.ToDecimal(responseString) > Convert.ToDecimal(Application.ProductVersion))
                {
                    MessageBox.Show("", "AGGIORNAMENTO");
                }
                else if (Convert.ToDecimal(responseString) <= Convert.ToDecimal(Application.ProductVersion))
                {
                    MessageBox.Show("", "NON AGGIORNAMENTO");
                }
            }


           

            
        }
    }
}
