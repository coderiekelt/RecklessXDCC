using Reckless.Sdk.EventArgs.Irc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Reckless.Client.Services
{
    public class DownloadService
    {
        private bool Shutdown;

        public void StartMonitoring()
        {
            this.Shutdown = false;
            
            Reckless.Sdk.Context.IrcService.OnDownloadStatusChanged += this.DownloadStatusChangedHandler;

            Thread monitorThread = new Thread(this.MonitorQueue);
            monitorThread.Start();

            Application.ApplicationExit += (object sender, EventArgs args) =>
            {
                this.Shutdown = true;
            };
        }

        private void MonitorQueue()
        {
            while (this.Shutdown == false)
            {
                if (Utilities.DownloadQueue == null)
                {
                    Thread.Sleep(1000);
                    continue;
                }

                if (Utilities.DownloadQueue.CurrentDownload != null)
                {
                    Thread.Sleep(1000);
                    continue;
                }

                if (Utilities.DownloadQueue.QueueItems.Count < 1)
                {
                    Thread.Sleep(1000);
                    continue;
                }
                
                if (Utilities.DownloadQueue.CurrentDownload == null)
                {
                    Utilities.DownloadQueue.PushNextItemToCurrent();
                    Reckless.Sdk.Context.IrcService.IrcClient.sendMessage(Utilities.DownloadQueue.CurrentDownload.Xdcc);

                    Thread.Sleep(1000);
                }
            }
        }

        private void DownloadStatusChangedHandler(object sender, DownloadStatusChangedEventArgs args)
        {
            SimpleIRCLib.SimpleIRC irc = Reckless.Sdk.Context.IrcService.IrcClient;

            string progress = irc.getDownloadProgress("progress").ToString();
            string speedmbps = irc.getDownloadProgress("mbps").ToString();
            string filename = irc.getDownloadProgress("filename").ToString();

            Utilities.DownloadQueue.UpdateCurrentDownloadInfo(filename, progress, speedmbps);
        }
    }
}
