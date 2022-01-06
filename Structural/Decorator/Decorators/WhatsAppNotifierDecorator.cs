namespace DesignPattern.Structural.Decorator.Decorators
{
    internal class WhatsAppNotifierDecorator : NotifierDecorator
    {
        private string PhoneNumber { get; set; }
        public WhatsAppNotifierDecorator(INotifier notifier, string phoneNumber) : base(notifier)
        {
            PhoneNumber = phoneNumber;
            SendSMS();
        }

        private void SendSMS()
        {
            Console.WriteLine($"Sending WhatsApp message to {this.PhoneNumber}");
            Console.WriteLine("Your latest operation was executed successfully");
        }
    }
}
