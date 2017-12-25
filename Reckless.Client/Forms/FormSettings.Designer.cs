namespace Reckless.Client.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.LabelIrcNickname = new System.Windows.Forms.Label();
            this.TextIrcNickname = new System.Windows.Forms.TextBox();
            this.LabelIrcPassword = new System.Windows.Forms.Label();
            this.TextIrcPassword = new System.Windows.Forms.TextBox();
            this.LabelDownloadDirectory = new System.Windows.Forms.Label();
            this.TextDownloadDirectory = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.ButtonSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelIrcNickname
            // 
            this.LabelIrcNickname.AutoSize = true;
            this.LabelIrcNickname.Location = new System.Drawing.Point(12, 9);
            this.LabelIrcNickname.Name = "LabelIrcNickname";
            this.LabelIrcNickname.Size = new System.Drawing.Size(79, 13);
            this.LabelIrcNickname.TabIndex = 0;
            this.LabelIrcNickname.Text = "IRC Nickname:";
            // 
            // TextIrcNickname
            // 
            this.TextIrcNickname.Location = new System.Drawing.Point(12, 25);
            this.TextIrcNickname.Name = "TextIrcNickname";
            this.TextIrcNickname.Size = new System.Drawing.Size(448, 20);
            this.TextIrcNickname.TabIndex = 1;
            // 
            // LabelIrcPassword
            // 
            this.LabelIrcPassword.AutoSize = true;
            this.LabelIrcPassword.Location = new System.Drawing.Point(12, 48);
            this.LabelIrcPassword.Name = "LabelIrcPassword";
            this.LabelIrcPassword.Size = new System.Drawing.Size(77, 13);
            this.LabelIrcPassword.TabIndex = 2;
            this.LabelIrcPassword.Text = "IRC Password:";
            // 
            // TextIrcPassword
            // 
            this.TextIrcPassword.Location = new System.Drawing.Point(12, 64);
            this.TextIrcPassword.Name = "TextIrcPassword";
            this.TextIrcPassword.PasswordChar = '*';
            this.TextIrcPassword.Size = new System.Drawing.Size(448, 20);
            this.TextIrcPassword.TabIndex = 3;
            // 
            // LabelDownloadDirectory
            // 
            this.LabelDownloadDirectory.AutoSize = true;
            this.LabelDownloadDirectory.Location = new System.Drawing.Point(12, 87);
            this.LabelDownloadDirectory.Name = "LabelDownloadDirectory";
            this.LabelDownloadDirectory.Size = new System.Drawing.Size(101, 13);
            this.LabelDownloadDirectory.TabIndex = 4;
            this.LabelDownloadDirectory.Text = "Download directory:";
            // 
            // TextDownloadDirectory
            // 
            this.TextDownloadDirectory.Location = new System.Drawing.Point(12, 103);
            this.TextDownloadDirectory.Name = "TextDownloadDirectory";
            this.TextDownloadDirectory.Size = new System.Drawing.Size(367, 20);
            this.TextDownloadDirectory.TabIndex = 5;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(385, 103);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 20);
            this.ButtonBrowse.TabIndex = 6;
            this.ButtonBrowse.Text = "Browse...";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // ButtonSaveSettings
            // 
            this.ButtonSaveSettings.Location = new System.Drawing.Point(361, 175);
            this.ButtonSaveSettings.Name = "ButtonSaveSettings";
            this.ButtonSaveSettings.Size = new System.Drawing.Size(99, 23);
            this.ButtonSaveSettings.TabIndex = 7;
            this.ButtonSaveSettings.Text = "Save settings";
            this.ButtonSaveSettings.UseVisualStyleBackColor = true;
            this.ButtonSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 210);
            this.Controls.Add(this.ButtonSaveSettings);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.TextDownloadDirectory);
            this.Controls.Add(this.LabelDownloadDirectory);
            this.Controls.Add(this.TextIrcPassword);
            this.Controls.Add(this.LabelIrcPassword);
            this.Controls.Add(this.TextIrcNickname);
            this.Controls.Add(this.LabelIrcNickname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "Reckless - Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelIrcNickname;
        private System.Windows.Forms.TextBox TextIrcNickname;
        private System.Windows.Forms.Label LabelIrcPassword;
        private System.Windows.Forms.TextBox TextIrcPassword;
        private System.Windows.Forms.Label LabelDownloadDirectory;
        private System.Windows.Forms.TextBox TextDownloadDirectory;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Button ButtonSaveSettings;
    }
}