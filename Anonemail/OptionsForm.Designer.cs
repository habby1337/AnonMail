namespace Anonemail
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.BClose = new System.Windows.Forms.Button();
            this.BCheckupdate = new System.Windows.Forms.Button();
            this.LVersion = new System.Windows.Forms.Label();
            this.LPowered = new System.Windows.Forms.Label();
            this.TBTo = new System.Windows.Forms.TextBox();
            this.LTo = new System.Windows.Forms.Label();
            this.BActivate = new System.Windows.Forms.Button();
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
            this.BClose.TabIndex = 1;
            this.BClose.Text = "X";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // BCheckupdate
            // 
            this.BCheckupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCheckupdate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCheckupdate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BCheckupdate.Location = new System.Drawing.Point(234, 295);
            this.BCheckupdate.Name = "BCheckupdate";
            this.BCheckupdate.Size = new System.Drawing.Size(99, 30);
            this.BCheckupdate.TabIndex = 2;
            this.BCheckupdate.Text = "Check Update";
            this.BCheckupdate.UseVisualStyleBackColor = true;
            this.BCheckupdate.Click += new System.EventHandler(this.BCheckupdate_Click);
            // 
            // LVersion
            // 
            this.LVersion.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LVersion.Location = new System.Drawing.Point(12, 295);
            this.LVersion.Name = "LVersion";
            this.LVersion.Size = new System.Drawing.Size(142, 30);
            this.LVersion.TabIndex = 3;
            this.LVersion.Text = "Version: 0.0.0.0";
            this.LVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LPowered
            // 
            this.LPowered.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LPowered.Location = new System.Drawing.Point(12, 10);
            this.LPowered.Name = "LPowered";
            this.LPowered.Size = new System.Drawing.Size(119, 95);
            this.LPowered.TabIndex = 4;
            this.LPowered.Text = "Powered by:\r\nanonymouse.org\r\n\r\nCoded by:\r\nHabby";
            // 
            // TBTo
            // 
            this.TBTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TBTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBTo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TBTo.Location = new System.Drawing.Point(77, 158);
            this.TBTo.Name = "TBTo";
            this.TBTo.Size = new System.Drawing.Size(238, 16);
            this.TBTo.TabIndex = 5;
            this.TBTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LTo
            // 
            this.LTo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LTo.Location = new System.Drawing.Point(12, 158);
            this.LTo.Name = "LTo";
            this.LTo.Size = new System.Drawing.Size(46, 16);
            this.LTo.TabIndex = 6;
            this.LTo.Text = "Key:";
            this.LTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BActivate
            // 
            this.BActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BActivate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActivate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BActivate.Location = new System.Drawing.Point(77, 180);
            this.BActivate.Name = "BActivate";
            this.BActivate.Size = new System.Drawing.Size(238, 29);
            this.BActivate.TabIndex = 7;
            this.BActivate.Text = "Activate";
            this.BActivate.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(359, 337);
            this.Controls.Add(this.BActivate);
            this.Controls.Add(this.LTo);
            this.Controls.Add(this.TBTo);
            this.Controls.Add(this.LPowered);
            this.Controls.Add(this.LVersion);
            this.Controls.Add(this.BCheckupdate);
            this.Controls.Add(this.BClose);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BCheckupdate;
        private System.Windows.Forms.Label LVersion;
        private System.Windows.Forms.Label LPowered;
        private System.Windows.Forms.TextBox TBTo;
        private System.Windows.Forms.Label LTo;
        private System.Windows.Forms.Button BActivate;
    }
}