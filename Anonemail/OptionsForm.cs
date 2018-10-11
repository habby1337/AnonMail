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
            try
            {
                LVersion.Text = "Version: " + Application.ProductVersion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("CURRENT EXE NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCheckupdate_Click(object sender, EventArgs e)
        {

            try
            {
                // Create web client simulating IE6.
                using (WebClient client = new WebClient())
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    // Download data.
                    byte[] arr = client.DownloadData("https://habby1337.github.io/anonmail/version.txt");                               //
                   
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    // Parse the returned data (if any) if needed.
                    var responseString = Encoding.UTF8.GetString(arr);

                    if (Convert.ToDecimal(responseString) > Convert.ToDecimal(Application.ProductVersion))
                    {
                        DialogResult result = MessageBox.Show("An Update was found...\n Update now?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {

                            var uri = new Uri("https://github.com/habby1337/AnonMail/releases/download/" + responseString + "/Anonemail.exe"); //

                            client.DownloadFileAsync(uri, "Anonemail1.exe");

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

                }
            catch (Exception ex)
            {

            }
        }
       

        public static void Completed(object o, AsyncCompletedEventArgs args)
        {

            MessageBox.Show("uninstall old version", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            string app_name = Application.StartupPath + "\\" + Application.ProductName + ".exe";
            string bat_name = app_name + ".bat";

            string bat = "@echo off\n"
                + ":loop\n"
                + "del \"" + app_name + "\"\n"
                + "if Exist \"" + app_name + "\" GOTO loop\n"
                + "ren Anonemail1.exe Anonemail.exe\n"
                + "del %0\n"
                + "start Anonemail.exe";

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
