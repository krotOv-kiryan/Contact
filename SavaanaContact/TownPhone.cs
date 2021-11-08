using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaanaContact
{
    class TownPhone : IPhone
    {

        public string Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetTypeName()
        {
            return "Town";
        }
    }
}
