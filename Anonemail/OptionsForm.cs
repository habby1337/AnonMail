using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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

               
                // Parse the returned data (if any) if needed.
                var responseString = Encoding.UTF8.GetString(arr);

                if (Convert.ToDecimal(responseString) > Convert.ToDecimal(Application.ProductVersion))
                {
                    DialogResult result = MessageBox.Show("An Update was found...\n Update now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {

                       // System.Diagnostics.Process.Start("https://github.com/habby1337/AnonMail/releases");
                        client.DownloadFile("https://github.com/habby1337/AnonMail/releases/tag/"+ responseString , "Anonmail1.exe");

                        Thread.Sleep(2000);
                        uninstall();


                    }
                    else
                    {

                    }
                }
                else if (Convert.ToDecimal(responseString) <= Convert.ToDecimal(Application.ProductVersion))
                {
                    MessageBox.Show("No update found", "Update", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }


             void uninstall()
            {
                string app_name = Application.StartupPath + "\\" + Application.ProductName + ".exe";
                string bat_name = app_name + ".bat";

                string bat = "@echo off\n"
                    + ":loop\n"
                    + "del \"" + app_name + "\"\n"
                    + "if Exist \"" + app_name + "\" GOTO loop\n"
                    + "ren Anonmail1.exe Anonmail.exe\n"
                    + "del %0\n"
                    + "start Anonmail.exe";

                StreamWriter file = new StreamWriter(bat_name);
                file.Write(bat);
                file.Close();

                Process bat_call = new Process();
                bat_call.StartInfo.FileName = bat_name;
                bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                bat_call.StartInfo.UseShellExecute = true;
                bat_call.Start();

                Application.Exit();
            }


        }
    }
}
