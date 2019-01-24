using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class SmsSender : Object, ISender
    {
        public string Message { get ; set ; }
        public string to { get; set ; }

        public void Send(string message, string to)
        {
            //Реализация для смс
            Console.WriteLine($"СМС сообщение {message} отправлено на номер {to}");
        }
    }
}
