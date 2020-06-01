using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterShow
{
    public class PhoneAdapter
    {
        private IPhone _IPhone;
        public PhoneAdapter(IPhone iPhone)
        {
            _IPhone = iPhone;
        }

        public void Call()
        {
            _IPhone.Call();
        }

        public void Message()
        {
            Console.WriteLine("Message");
        }
    }
}
