using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class ServiceLocator
    {
        public static ISender Sender
        {
            get
            {
                return new SmsSender();
            }
        }
    }
}
