using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Adapter.SMSAdapter.Messages
{
    class SMSMessage : IMessage
    {
        private string Message { get; set; }
        private string Number { get; set; }

        public SMSMessage(string message, string number)
        {
            Message = message;
            Number = number;
        }

        public string GetMessage()
        {
            return Message;
        }

        public string GetNumber()
        {
            return Number;
        }

        public bool ValidateMessage()
        {
            return Message.Length < 10;
        }

        public bool ValidateNumber()
        {
            return Number.Length < 8;
        }
    }
}
