namespace Reckless.Client.Forms
{
    partial class FormAddDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDownload));
            this.LabelEnterIrcMessage = new System.Windows.Forms.Label();
            this.TextIrcMessage = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelEnterIrcMessage
            // 
            this.LabelEnterIrcMessage.AutoSize = true;
            this.LabelEnterIrcMessage.Location = new System.Drawing.Point(12, 9);
            this.LabelEnterIrcMessage.Name = "LabelEnterIrcMessage";
            this.LabelEnterIrcMessage.Size = new System.Drawing.Size(158, 13);
            this.LabelEnterIrcMessage.TabIndex = 0;
            this.LabelEnterIrcMessage.Text = "Please enter your IRC message:";
            // 
            // TextIrcMessage
            // 
            this.TextIrcMessage.Location = new System.Drawing.Point(12, 25);
            this.TextIrcMessage.Name = "TextIrcMessage";
            this.TextIrcMessage.Size = new System.Drawing.Size(387, 20);
            this.TextIrcMessage.TabIndex = 1;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(324, 74);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubmit.TabIndex = 2;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // FormAddDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 109);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TextIrcMessage);
            this.Controls.Add(this.LabelEnterIrcMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddDownload";
            this.Text = "Reckless - Add Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEnterIrcMessage;
        private System.Windows.Forms.TextBox TextIrcMessage;
        private System.Windows.Forms.Button ButtonSubmit;
    }
}