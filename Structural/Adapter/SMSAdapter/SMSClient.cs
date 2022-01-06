using DesignPattern.Structural.Adapter.SMSAdapter.Messages;

namespace DesignPattern.Structural.Adapter.SMSAdapter
{
    abstract class SMSClient
    {
        protected List<SMSMessage> Messages { get; set; }
        protected string DeliverStatus { get; set; }
        public SMSClient(List<SMSMessage> messages) => Messages = messages;

        public void SendSMS(SMSMessage message)
        {
            Messages.Add(message);
        }
        public void AddMessage(SMSMessage messages)
        {
            Messages.Add(messages);
        }
        abstract public bool filterNumbers();
        abstract public bool Send();
        abstract public string getDeliveryStatus();

    }
}
