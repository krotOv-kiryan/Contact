using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaanaContact
{
    public interface IPhone
    {
        public string Number { get; set; }
        public string GetTypeName();
    }
}
