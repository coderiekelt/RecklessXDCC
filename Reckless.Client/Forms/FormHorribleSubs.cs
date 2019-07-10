using Reckless.Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reckless.Client.Forms
{
    public partial class FormHorribleSubs : Form
    {
        public FormHorribleSubs()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            this.GridResults.ClearSelection();
            this.GridResults.Rows.Clear();

            string uri = String.Format("http://xdcc.horriblesubs.info/search.php?t={0}", Uri.EscapeUriString(this.TextSearch.Text));
            string javascript = this.Get(uri);

            string[] lines = javascript.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            List<Packlist> packlists = new List<Packlist>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "," }, StringSplitOptions.None);

                Packlist packlist = new Packlist();

                int i = 0;

                foreach (string part in parts)
                {
                    if (part.Length < 5)
                    {
                        continue;
                    }

                    // Bot
                    if (i == 0)
                    {
                        packlist.Bot = part.Substring(part.IndexOf("b:") + 3);
                        packlist.Bot = packlist.Bot.Substring(0, packlist.Bot.Length - 1);
                    }

                    // Pack
                    if (i == 1)
                    {
                        packlist.Pack = part.Substring(part.IndexOf("n:") + 2);
                    }

                    // Size
                    if (i == 2)
                    {
                        packlist.Size = part.Substring(part.IndexOf("s:") + 2);
                    }

                    // File
                    if (i == 3)
                    {
                        packlist.Filename = part.Substring(part.IndexOf("f:") + 3);
                        packlist.Filename = packlist.Filename.Substring(0, packlist.Filename.Length - 3);
                    }

                    i++;
                }

                packlists.Add(packlist);
            }

            foreach (Packlist packlist in packlists)
            {
                if (packlist.Filename == null)
                {
                    continue;
                }

                this.GridResults.Rows.Add(new string[] { packlist.Bot, packlist.Filename, packlist.Pack, String.Format("{0} Mb", packlist.Size) });
            }
        }

        private string Get(string uri)
        {
            using (WebResponse wr = WebRequest.Create(uri).GetResponse())
            {
                using (StreamReader sr = new StreamReader(wr.GetResponseStream()))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        private void ButtonAddToQueue_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridResults.SelectedRows)
            {
                Download download = new Download();

                download.Filename = row.Cells[1].Value.ToString();
                download.Xdcc = String.Format("/msg {0} xdcc send #{1}", row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());

                Utilities.DownloadQueue.QueueDownload(download);
            }
        }
    }
}
