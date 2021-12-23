using DesignPattern.Structural.Adapter.SMSAdapter.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Adapter.SMSAdapter.Adapters.ABCSMSManager
{
    internal class SMSManager
    {
        public void send(List<SMSMessage> Messages)
        {
            if (checkConnection() && authenticate() && connect())
            {
                foreach (SMSMessage message in Messages)
                {
                    Console.WriteLine($"Your message {message.GetMessage()} is being sent to {message.GetNumber()}\n");
                }
            }
        }

        public bool connect()
        {
            return true;
        }

        public bool checkConnection()
        {
            return true;
        }

        public bool authenticate()
        {
            return true;
        }

        public bool validatePhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length < 8;
        }

        public string getDeliveryStatus()
        {
            return new Random().Next(5,8).ToString() ;
        }
    }
}
