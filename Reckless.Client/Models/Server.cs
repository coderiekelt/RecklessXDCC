using System;

namespace Reckless.Client.Models
{
    public class Server
    {
        public string IpAddress { get; set; }

        public int Port { get; set; }

        public string Channel { get; set; }

        public override string ToString()
        {
            return String.Format("{0} @ {1}", Channel, IpAddress);
        }
    }
}
