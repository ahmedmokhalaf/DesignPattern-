using DesignPattern.Structural.Adapter.SMSAdapter.Adapters.ABCSMSManager;
using DesignPattern.Structural.Adapter.SMSAdapter.Messages;

namespace DesignPattern.Structural.Adapter.SMSAdapter.Adapters
{
    internal class ABSSMSClientAdapter : SMSClient
    {
        private SMSManager? Manager = null;

        public ABSSMSClientAdapter(List<SMSMessage> messages) : base(messages)
        {
            Manager = new SMSManager();
        }

        public override bool filterNumbers()
        {
            Messages.Where(M => M.ValidateNumber()).ToList().ForEach((M) => Messages.Remove(M));
            return Messages.Count > 0;
        }

        public override string getDeliveryStatus()
        {
            return DeliverStatus;
        }

        public override bool Send()
        {
            foreach (SMSMessage message in Messages)
            {
                DeliverStatus = new Random().Next(1, 4).ToString();
                Console.WriteLine($"Message is being sent { message.GetNumber() } {message.GetMessage()} and DeliverStatus : {DeliverStatus}'\n");
            }
            return getDeliveryStatus().Equals(SMSDeliveryStatus.SMSDeliveryStatusEnum.SENT.ToString());
        }
    }
}
