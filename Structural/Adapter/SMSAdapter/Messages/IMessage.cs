using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Adapter.SMSAdapter.Messages
{
    interface IMessage
    {
        public string GetMessage();
        public string GetNumber();
        public bool ValidateMessage();
        public bool ValidateNumber();
    }
}
