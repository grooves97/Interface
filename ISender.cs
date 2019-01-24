using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ISender
    {
        string Message { get; set; }
        string to { get; set; }

        void Send(string message, string to);
    }
}
