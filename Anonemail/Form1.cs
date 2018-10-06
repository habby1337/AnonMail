using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;    // for StreamReader
using System.Collections.Specialized;

namespace Anonemail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) {Application.Exit();}

        private void BAbout_Click(object sender, EventArgs e) { MessageBox.Show("Made with <3 by \n Habby", "About", MessageBoxButtons.OK, MessageBoxIcon.Warning);}

        private void BSend_Click(object sender, EventArgs e)
        {
            string touser;
            string subject;
            string message;

            //Prende le informazioni dalle TextBox
            touser = TBTo.Text;
            subject = TBSubject.Text;
            message = TBMessage.Text;

            string url = "http://anonymouse.org/cgi-bin/anon-email.cgi";


            DialogResult result = MessageBox.Show("Do you want to send the email?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {          

                var client = new WebClient();
                var method = "POST"; // If your endpoint expects a GET then do it.
                var parameters = new NameValueCollection();           

                parameters.Add("to", touser);
                parameters.Add("subject", subject);
                parameters.Add("text", message);

                /* Always returns a byte[] array data as a response. */
                var response_data = client.UploadValues(url, method, parameters);

                // Parse the returned data (if any) if needed.
                var responseString = UnicodeEncoding.UTF8.GetString(response_data);


                if (responseString.Contains("The e-mail has been sent anonymously!")) { MessageBox.Show("The e-mail has been sent anonymously! \n Please note: in order to increase your privacy, the mail will be randomly delayed up to 12 hours.", "INFO",MessageBoxButtons.OK,MessageBoxIcon.Information); }
                else if (responseString.Contains("Error - This is not a valid e-mail address!")) { MessageBox.Show("This is not a valid e-mail address!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                TBTo.Clear();

            } else { MessageBox.Show("The email will be not sent", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information); }

           
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            TBTo.Clear();
            TBSubject.Clear();
            TBMessage.Clear();
        }

        private void BOptions_Click(object sender, EventArgs e)
        {
            OptionsForm optionsFm = new OptionsForm();

            optionsFm.Show();
        }
    }
}
