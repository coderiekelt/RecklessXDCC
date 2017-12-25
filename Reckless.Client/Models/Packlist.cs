using System;

namespace Reckless.Client.Models
{
    public class Packlist
    {
        public string Bot { get; set; }

        public string Pack { get; set; }

        public string Size { get; set; }

        public string Filename { get; set; }

        public string ToXdcc()
        {
            return String.Format("/msg {0} xdcc send #{1}", this.Bot, this.Pack);
        }
    }
}
