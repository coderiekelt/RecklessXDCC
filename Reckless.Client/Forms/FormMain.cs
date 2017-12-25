using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Reckless.Sdk.EventArgs.Irc;
using Reckless.Client.Models;
using Reckless.Client.Properties;
using Reckless.Client.Services;
using System.Diagnostics;

namespace Reckless.Client.Forms
{
    public partial class FormMain : Form
    {
        private DownloadService DownloadService;

        public FormMain()
        {
            this.DownloadService = new DownloadService();

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DownloadDirectory == null || Properties.Settings.Default.DownloadDirectory.Length < 1)
            {
                Properties.Settings.Default.DownloadDirectory = Reckless.Sdk.Context.StorageService.DownloadDirectory;
                Properties.Settings.Default.Save();
            }

            Reckless.Sdk.Context.DownloadDirectory = Properties.Settings.Default.DownloadDirectory;

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;

            this.Text += String.Format(" (Version {0})", version);

            this.DownloadService.StartMonitoring();

            if (Utilities.DownloadQueue == null)
            {
                Utilities.DownloadQueue = new DownloadQueue();
            }

            Utilities.DownloadQueue.OnDownloadQueueChanged += this.DownloadQueueChangedHandler;

            if (Utilities.ServerCollection.Servers.Count < 1)
            {
                // Here, have some #HorribleSubs @ Rizon
                Server horribleSubs = new Server { IpAddress = "irc.rizon.net", Port = 6660, Channel = "#horriblesubs" };
                Utilities.ServerCollection.Servers.Add(horribleSubs);
                Utilities.SaveServerCollection();
            }

            foreach (Server server in Utilities.ServerCollection.Servers)
            {
                this.ListServers.Items.Add(server);
            }

            Reckless.Sdk.Context.IrcService.OnChatOutput += this.ChatOutputHandler;
            Reckless.Sdk.Context.IrcService.OnRawOutput += this.RawOutputHandler;
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (this.ListServers.SelectedItem == null)
            {
                return;
            }

            Server selectedServer = (Server)this.ListServers.SelectedItem;
            Settings settings = Properties.Settings.Default;

            this.TextConsole.Text = "Loading IRC library... give it a minute. :-) (Yes, this happens every time.)";

            Thread connectThread = new Thread(() =>
            {
                Reckless.Sdk.Context.IrcService.Connect(selectedServer.IpAddress, selectedServer.Port, settings.Username, selectedServer.Channel, settings.Password);

                this.ButtonDisconnect.InvokeIfRequired(() =>
                {
                    this.ButtonConnect.Enabled = false;
                    this.ButtonDisconnect.Enabled = true;
                    this.ButtonSearchHorribleSubs.Enabled = true;
                    this.ButtonAddDownload.Enabled = true;
                });
            });

            connectThread.Start();
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            Reckless.Sdk.Context.IrcService.Disconnect();

            this.ButtonConnect.Enabled = true;
            this.ButtonDisconnect.Enabled = false;
            this.ButtonSearchHorribleSubs.Enabled = false;
            this.ButtonAddDownload.Enabled = false;
        }

        private void DownloadQueueChangedHandler(object sender, DownloadQueueChangedEventArgs args)
        {
            this.GridDownloads.InvokeIfRequired(() =>
            {
                this.GridDownloads.Rows.Clear();

                if (args.DownloadQueue.CurrentDownload != null)
                {
                    this.GridDownloads.Rows.Add(new string[] {
                    "In Progress",
                    args.DownloadQueue.CurrentDownload.Filename,
                    String.Format("{0}%", args.DownloadQueue.CurrentDownload.Progress),
                    String.Format("{0} Mb/s", args.DownloadQueue.CurrentDownload.Speed)
                });
                }

                foreach (Download download in args.DownloadQueue.QueueItems)
                {
                    this.GridDownloads.Rows.Add(new string[] { "In Queue", download.Filename ?? download.Xdcc, "N/A", "N/A" });
                }
            });
        }

        private void ChatOutputHandler(object sender, ChatOutputEventArgs args)
        {
            if (args.Message.Contains("VERSION"))
            {
                string response = String.Format("/msg {0} {1}", args.User, "001-RECK");

                Reckless.Sdk.Context.IrcService.IrcClient.sendMessage(response);
            }

            this.TextConsole.InvokeIfRequired(() => { this.TextConsole.Text = String.Format("{0}: {1}{2}{3}", args.User, args.Message, Environment.NewLine, this.TextConsole.Text); });
        }

        private void RawOutputHandler(object sender, RawOutputEventArgs args)
        {
            this.TextConsole.InvokeIfRequired(() => { this.TextConsole.Text = String.Format("{0}{1}{2}", args.Message, Environment.NewLine, this.TextConsole.Text); });
        }

        private void ButtonAddDownload_Click(object sender, EventArgs e)
        {
            FormAddDownload formAddDownload = new FormAddDownload();
            formAddDownload.Show();
        }

        private void ButtonSearchHorribleSubs_Click(object sender, EventArgs e)
        {
            FormHorribleSubs formHorribleSubs = new FormHorribleSubs();
            formHorribleSubs.Show();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
        }
    }
}
