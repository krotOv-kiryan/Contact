using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaanaContact
{
    public class NickNames
    {
        public List<Nick> ListNicks { get; set; } = new List<Nick>();

        public void AddNick(string nick, string url)
        {
            Nick newNick = new Nick { Name = nick, Url = url };
            ListNicks.Add(newNick);
        }

        public void RemoveNick(Nick nick)
        {
            ListNicks.Remove(nick);
        }
    }
}
