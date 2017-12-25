namespace Reckless.Client.Forms
{
    partial class FormHorribleSubs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorribleSubs));
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.GridResults = new System.Windows.Forms.DataGridView();
            this.Bot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonAddToQueue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(744, 12);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(77, 23);
            this.ButtonSearch.TabIndex = 0;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(12, 14);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(726, 20);
            this.TextSearch.TabIndex = 1;
            // 
            // GridResults
            // 
            this.GridResults.AllowUserToAddRows = false;
            this.GridResults.AllowUserToDeleteRows = false;
            this.GridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bot,
            this.Filename,
            this.Pack,
            this.Size});
            this.GridResults.Location = new System.Drawing.Point(12, 40);
            this.GridResults.Name = "GridResults";
            this.GridResults.ReadOnly = true;
            this.GridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridResults.Size = new System.Drawing.Size(809, 529);
            this.GridResults.TabIndex = 2;
            // 
            // Bot
            // 
            this.Bot.HeaderText = "Bot";
            this.Bot.Name = "Bot";
            this.Bot.ReadOnly = true;
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Filename";
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            // 
            // Pack
            // 
            this.Pack.HeaderText = "Pack";
            this.Pack.Name = "Pack";
            this.Pack.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // ButtonAddToQueue
            // 
            this.ButtonAddToQueue.Location = new System.Drawing.Point(644, 575);
            this.ButtonAddToQueue.Name = "ButtonAddToQueue";
            this.ButtonAddToQueue.Size = new System.Drawing.Size(177, 23);
            this.ButtonAddToQueue.TabIndex = 3;
            this.ButtonAddToQueue.Text = "Add selected items to queue";
            this.ButtonAddToQueue.UseVisualStyleBackColor = true;
            this.ButtonAddToQueue.Click += new System.EventHandler(this.ButtonAddToQueue_Click);
            // 
            // FormHorribleSubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 610);
            this.Controls.Add(this.ButtonAddToQueue);
            this.Controls.Add(this.GridResults);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.ButtonSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHorribleSubs";
            this.Text = "Reckless - Horrible Subs Browser";
            ((System.ComponentModel.ISupportInitialize)(this.GridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.DataGridView GridResults;
        private System.Windows.Forms.Button ButtonAddToQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
    }
}