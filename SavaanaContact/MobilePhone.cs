using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaanaContact
{
    public class MobilePhone : IPhone
    {
        public string Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetTypeName()//TypeName ошибка с C#7.3 
        {
            return "Mobile";
        }
    }
}
