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
