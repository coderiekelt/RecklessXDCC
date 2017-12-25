using System.Collections.Generic;

namespace Reckless.Client.Models
{
    public class ServerCollection
    {
        public List<Server> Servers { get; set; }

        public ServerCollection()
        {
            this.Servers = new List<Server>();
        }
    }
}
