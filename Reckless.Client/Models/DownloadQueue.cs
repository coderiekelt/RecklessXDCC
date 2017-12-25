using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: REFACTOR THE SHIT OUT OF THIS

namespace Reckless.Client.Models
{
    public class DownloadQueueChangedEventArgs
    {
        public DownloadQueue DownloadQueue;
    }

    public delegate void DownloadQueueChangedHandler(object sender, DownloadQueueChangedEventArgs arguments);

    public class DownloadQueue
    {
        public event DownloadQueueChangedHandler OnDownloadQueueChanged;

        public Download CurrentDownload;

        public List<Download> QueueItems;

        public DownloadQueue()
        {
            this.QueueItems = new List<Download>();
        }

        public bool HasItemsInQueue()
        {
            return (QueueItems.Count > 0);
        }

        public void PushNextItemToCurrent()
        {
            this.CurrentDownload = this.QueueItems[0];
            this.QueueItems.RemoveAt(0);
        }

        public void QueueDownload(Download download)
        {
            this.QueueItems.Add(download);

            OnDownloadQueueChanged(this, new DownloadQueueChangedEventArgs { DownloadQueue = this });
        }

        public void UpdateCurrentDownloadInfo(string filename, string progress, string speed)
        {
            if (progress == "100")
            {
                this.CurrentDownload = null;

                OnDownloadQueueChanged(this, new DownloadQueueChangedEventArgs { DownloadQueue = this });

                return;
            }

            this.CurrentDownload.Filename = filename;
            this.CurrentDownload.Progress = progress;
            this.CurrentDownload.Speed = speed;

            if (this.OnDownloadQueueChanged == null)
            {
                return;
            }

            OnDownloadQueueChanged(this, new DownloadQueueChangedEventArgs { DownloadQueue = this });
        }
    }
}
