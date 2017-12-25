namespace Reckless.Client.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.TextConsole = new System.Windows.Forms.TextBox();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ListServers = new System.Windows.Forms.ListBox();
            this.GridDownloads = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddDownload = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonSearchHorribleSubs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDownloads)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(12, 378);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(185, 49);
            this.ButtonConnect.TabIndex = 0;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // TextConsole
            // 
            this.TextConsole.Location = new System.Drawing.Point(203, 402);
            this.TextConsole.Multiline = true;
            this.TextConsole.Name = "TextConsole";
            this.TextConsole.ReadOnly = true;
            this.TextConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextConsole.Size = new System.Drawing.Size(637, 135);
            this.TextConsole.TabIndex = 1;
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Enabled = false;
            this.ButtonDisconnect.Location = new System.Drawing.Point(12, 433);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(185, 49);
            this.ButtonDisconnect.TabIndex = 2;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ListServers
            // 
            this.ListServers.FormattingEnabled = true;
            this.ListServers.Location = new System.Drawing.Point(12, 12);
            this.ListServers.Name = "ListServers";
            this.ListServers.Size = new System.Drawing.Size(185, 355);
            this.ListServers.TabIndex = 3;
            // 
            // GridDownloads
            // 
            this.GridDownloads.AllowUserToAddRows = false;
            this.GridDownloads.AllowUserToDeleteRows = false;
            this.GridDownloads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDownloads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Filename,
            this.Progress,
            this.Speed});
            this.GridDownloads.Location = new System.Drawing.Point(203, 12);
            this.GridDownloads.Name = "GridDownloads";
            this.GridDownloads.ReadOnly = true;
            this.GridDownloads.Size = new System.Drawing.Size(637, 355);
            this.GridDownloads.TabIndex = 4;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Filename";
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            // 
            // Progress
            // 
            this.Progress.HeaderText = "Progress";
            this.Progress.Name = "Progress";
            this.Progress.ReadOnly = true;
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            this.Speed.ReadOnly = true;
            // 
            // ButtonAddDownload
            // 
            this.ButtonAddDownload.Enabled = false;
            this.ButtonAddDownload.Location = new System.Drawing.Point(718, 373);
            this.ButtonAddDownload.Name = "ButtonAddDownload";
            this.ButtonAddDownload.Size = new System.Drawing.Size(122, 23);
            this.ButtonAddDownload.TabIndex = 5;
            this.ButtonAddDownload.Text = "Add Download";
            this.ButtonAddDownload.UseVisualStyleBackColor = true;
            this.ButtonAddDownload.Click += new System.EventHandler(this.ButtonAddDownload_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Location = new System.Drawing.Point(12, 488);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(185, 49);
            this.ButtonSettings.TabIndex = 6;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonSearchHorribleSubs
            // 
            this.ButtonSearchHorribleSubs.Enabled = false;
            this.ButtonSearchHorribleSubs.Location = new System.Drawing.Point(203, 373);
            this.ButtonSearchHorribleSubs.Name = "ButtonSearchHorribleSubs";
            this.ButtonSearchHorribleSubs.Size = new System.Drawing.Size(175, 23);
            this.ButtonSearchHorribleSubs.TabIndex = 7;
            this.ButtonSearchHorribleSubs.Text = "Search HorribleSubs";
            this.ButtonSearchHorribleSubs.UseVisualStyleBackColor = true;
            this.ButtonSearchHorribleSubs.Click += new System.EventHandler(this.ButtonSearchHorribleSubs_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 549);
            this.Controls.Add(this.ButtonSearchHorribleSubs);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonAddDownload);
            this.Controls.Add(this.GridDownloads);
            this.Controls.Add(this.ListServers);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.TextConsole);
            this.Controls.Add(this.ButtonConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Reckless XDCC";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDownloads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.TextBox TextConsole;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.ListBox ListServers;
        private System.Windows.Forms.DataGridView GridDownloads;
        private System.Windows.Forms.Button ButtonAddDownload;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonSearchHorribleSubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
    }
}

