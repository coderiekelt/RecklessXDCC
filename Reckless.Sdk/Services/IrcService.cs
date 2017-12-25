using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reckless.Sdk.EventArgs.Irc;
using SimpleIRCLib;

namespace Reckless.Sdk.Services
{
    public delegate void ChatOutputHandler(object sender, ChatOutputEventArgs arguments);
    public delegate void RawOutputHandler(object sender, RawOutputEventArgs arguments);
    public delegate void DebugOutputHandler(object sender, DebugOutputEventArgs arguments);
    public delegate void DownloadStatusChangedHandler(object sender, DownloadStatusChangedEventArgs arguments);
    public delegate void UserListReceivedHandler(object sender, UserListReceivedEventArgs arguments);

    public class IrcService
    {
        public event ChatOutputHandler OnChatOutput;
        public event RawOutputHandler OnRawOutput;
        public event DebugOutputHandler OnDebugOutput;
        public event DownloadStatusChangedHandler OnDownloadStatusChanged;
        public event UserListReceivedHandler OnUserListReceived;

        public SimpleIRC IrcClient;

        public bool Connected;

        public IrcService()
        {
            this.Connected = false;
        }

        public void Connect(string ipAddress, int port, string username, string channel, string password = "", bool force = false)
        {
            if (force == true && this.Connected == true)
            {
                this.IrcClient.stopClient();
                this.Connected = false;
            }

            if (this.Connected == true)
            {
                throw new Exception("Attempted to establish connection to a new IRC server whilst the current one is still active.");
            }

            this.IrcClient = new SimpleIRC();
            this.IrcClient.setupIrc(ipAddress, port, username, password, channel, this.ChatOutputDelegate);
            this.HookEventsToIrcClient();
            this.IrcClient.startClient();

            this.Connected = true;
        }

        public void Disconnect()
        {
            this.IrcClient.stopClient();
            this.Connected = false;
        }

        private void HookEventsToIrcClient()
        {
            this.IrcClient.setDebugCallback(this.DebugOutputDelegate);
            this.IrcClient.setRawOutput(this.RawOutputDelegate);
            this.IrcClient.setDownloadStatusChangeCallback(this.DownloadStatusChangedDelegate);
            this.IrcClient.setUserListReceivedCallback(this.UserListReceivedDelegate);

            this.IrcClient.setCustomDownloadDir(Context.DownloadDirectory);
        }

        private void ChatOutputDelegate(string user, string message)
        {
            if (this.OnChatOutput == null)
            {
                return;
            }

            this.OnChatOutput(this, new ChatOutputEventArgs { User = user, Message = message });
        }

        private void DebugOutputDelegate(string message)
        {
            if (this.OnDebugOutput == null)
            {
                return;
            }

            this.OnDebugOutput(this, new DebugOutputEventArgs { Message = message });
        }

        private void RawOutputDelegate(string message)
        {
            if (this.OnRawOutput == null)
            {
                return;
            }

            this.OnRawOutput(this, new RawOutputEventArgs { Message = message });
        }

        private void DownloadStatusChangedDelegate()
        {
            if (this.OnDownloadStatusChanged == null)
            {
                return;
            }

            this.OnDownloadStatusChanged(this, new DownloadStatusChangedEventArgs());
        }

        private void UserListReceivedDelegate(string[] users)
        {
            if (this.OnUserListReceived == null)
            {
                return;
            }

            this.OnUserListReceived(this, new UserListReceivedEventArgs { Users = users });
        }
    }
}
