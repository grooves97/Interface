using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class EmailSender : Object, ISender,ILogger
    {
        public string Message { get; set ; }
        public string to { get ; set; }
        string ISender.Message { get; set; }
        string ISender.to { get; set ; }

        void ISender.Send(string message, string to)
        {
            Console.WriteLine($"Email сообщения {message} отправлено на почту {to}");
        }

        void ILogger.Send(string message, string to)
        {
            throw new NotImplementedException();
        }

        public void Send(string message,string to)
        {
            (this as ILogger).Send(message,to);
            (this as ISender).Send(message,to);
        }
    }
}
