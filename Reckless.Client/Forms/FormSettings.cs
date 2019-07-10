using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reckless.Client.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings settings = Properties.Settings.Default;

            settings.Username = this.TextIrcNickname.Text;
            settings.Password = this.TextIrcPassword.Text;
            settings.DownloadDirectory = this.TextDownloadDirectory.Text;

            Reckless.Sdk.Context.DownloadDirectory = this.TextDownloadDirectory.Text;

            settings.Save();

            MessageBox.Show("Your settings have been saved!");
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            Properties.Settings settings = Properties.Settings.Default;

            this.TextIrcNickname.Text = settings.Username;
            this.TextIrcPassword.Text = settings.Password;
            this.TextDownloadDirectory.Text = settings.DownloadDirectory;
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                this.TextDownloadDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
