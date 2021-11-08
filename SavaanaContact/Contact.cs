using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaanaContact
{
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public Phones Phones { get; set; }
        public NickNames Nicknames { get; set; }
    }
}
