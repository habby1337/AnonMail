namespace Anonemail
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BClose = new System.Windows.Forms.Button();
            this.BAbout = new System.Windows.Forms.Button();
            this.TBTo = new System.Windows.Forms.TextBox();
            this.LTo = new System.Windows.Forms.Label();
            this.LSubject = new System.Windows.Forms.Label();
            this.TBSubject = new System.Windows.Forms.TextBox();
            this.LMessage = new System.Windows.Forms.Label();
            this.TBMessage = new System.Windows.Forms.TextBox();
            this.BSend = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BClose
            // 
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BClose.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BClose.Location = new System.Drawing.Point(306, 2);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(41, 30);
            this.BClose.TabIndex = 0;
            this.BClose.Text = "X";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // BAbout
            // 
            this.BAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAbout.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAbout.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BAbout.Location = new System.Drawing.Point(12, 2);
            this.BAbout.Name = "BAbout";
            this.BAbout.Size = new System.Drawing.Size(78, 30);
            this.BAbout.TabIndex = 1;
            this.BAbout.Text = "About";
            this.BAbout.UseVisualStyleBackColor = true;
            this.BAbout.Click += new System.EventHandler(this.BAbout_Click);
            // 
            // TBTo
            // 
            this.TBTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TBTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TBTo.Location = new System.Drawing.Point(81, 55);
            this.TBTo.Name = "TBTo";
            this.TBTo.Size = new System.Drawing.Size(240, 16);
            this.TBTo.TabIndex = 2;
            this.TBTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LTo
            // 
            this.LTo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LTo.Location = new System.Drawing.Point(29, 55);
            this.LTo.Name = "LTo";
            this.LTo.Size = new System.Drawing.Size(46, 16);
            this.LTo.TabIndex = 3;
            this.LTo.Text = "To:";
            this.LTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSubject
            // 
            this.LSubject.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LSubject.Location = new System.Drawing.Point(12, 94);
            this.LSubject.Name = "LSubject";
            this.LSubject.Size = new System.Drawing.Size(63, 16);
            this.LSubject.TabIndex = 4;
            this.LSubject.Text = "Subject:";
            this.LSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBSubject
            // 
            this.TBSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TBSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSubject.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TBSubject.Location = new System.Drawing.Point(81, 94);
            this.TBSubject.Name = "TBSubject";
            this.TBSubject.Size = new System.Drawing.Size(240, 16);
            this.TBSubject.TabIndex = 5;
            this.TBSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LMessage
            // 
            this.LMessage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LMessage.Location = new System.Drawing.Point(12, 136);
            this.LMessage.Name = "LMessage";
            this.LMessage.Size = new System.Drawing.Size(63, 16);
            this.LMessage.TabIndex = 6;
            this.LMessage.Text = "Message:";
            this.LMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBMessage
            // 
            this.TBMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TBMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBMessage.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TBMessage.Location = new System.Drawing.Point(81, 136);
            this.TBMessage.Multiline = true;
            this.TBMessage.Name = "TBMessage";
            this.TBMessage.Size = new System.Drawing.Size(240, 120);
            this.TBMessage.TabIndex = 7;
            // 
            // BSend
            // 
            this.BSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSend.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSend.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BSend.Location = new System.Drawing.Point(81, 295);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(109, 30);
            this.BSend.TabIndex = 8;
            this.BSend.Text = "Send";
            this.BSend.UseVisualStyleBackColor = true;
            this.BSend.Click += new System.EventHandler(this.BSend_Click);
            // 
            // BClear
            // 
            this.BClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BClear.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BClear.Location = new System.Drawing.Point(212, 295);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(109, 30);
            this.BClear.TabIndex = 9;
            this.BClear.Text = "Reset";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BOptions
            // 
            this.BOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOptions.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOptions.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BOptions.Location = new System.Drawing.Point(148, 2);
            this.BOptions.Name = "BOptions";
            this.BOptions.Size = new System.Drawing.Size(78, 30);
            this.BOptions.TabIndex = 10;
            this.BOptions.Text = "Options";
            this.BOptions.UseVisualStyleBackColor = true;
            this.BOptions.Click += new System.EventHandler(this.BOptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(359, 337);
            this.Controls.Add(this.BOptions);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BSend);
            this.Controls.Add(this.TBMessage);
            this.Controls.Add(this.LMessage);
            this.Controls.Add(this.TBSubject);
            this.Controls.Add(this.LSubject);
            this.Controls.Add(this.LTo);
            this.Controls.Add(this.TBTo);
            this.Controls.Add(this.BAbout);
            this.Controls.Add(this.BClose);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnonMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BAbout;
        private System.Windows.Forms.TextBox TBTo;
        private System.Windows.Forms.Label LTo;
        private System.Windows.Forms.Label LSubject;
        private System.Windows.Forms.TextBox TBSubject;
        private System.Windows.Forms.Label LMessage;
        private System.Windows.Forms.TextBox TBMessage;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BOptions;
    }
}

