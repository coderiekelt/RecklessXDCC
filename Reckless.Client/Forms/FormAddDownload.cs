using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reckless.Client.Models;

namespace Reckless.Client.Forms
{
    public partial class FormAddDownload : Form
    {
        public FormAddDownload()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Download download = new Download { Xdcc = this.TextIrcMessage.Text };

            Utilities.DownloadQueue.QueueDownload(download);

            this.Close();
        }
    }
}
