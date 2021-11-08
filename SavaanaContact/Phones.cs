using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavaanaContact
{
    public class Phones
    {
        public List<IPhone> ListPhones { get; set; } = new List<IPhone>();
        public IPhone DefaultPhone { get; set; } // = new IPhone DefaultPhone();


        public void AddPhone(string number)
        {
            new MobilePhone { Number = number };
            if (ListPhones.Count == 0)
            {
                MobilePhone newMobilePhone = new MobilePhone { };
                ListPhones.Add(newMobilePhone);
                DefaultPhone = newMobilePhone;
            }
            else
                ListPhones.Add(new MobilePhone { });
        }
        public void ChangeTypePhone(IPhone phone)
        {
            int index = ListPhones.IndexOf(phone);
            if (index == -1) { return; }
            else
            {
                if (phone is MobilePhone)
                {
                    TownPhone newTypePhone = new TownPhone { Number = phone.Number };
                }
                else
                if (phone is TownPhone)
                {
                    MobilePhone newTypePhone = new MobilePhone { Number = phone.Number };
                }
                if (phone == DefaultPhone) { DefaultPhone = phone; } 
                ListPhones.RemoveAt(index);
                ListPhones.Add(phone);
            }
        }
        public void RemovePhone(IPhone phone)
        {
            int index = ListPhones.IndexOf(phone);
            ListPhones.RemoveAt(index);
        }

    }
}
