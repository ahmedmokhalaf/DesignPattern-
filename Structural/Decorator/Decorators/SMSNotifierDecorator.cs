namespace DesignPattern.Structural.Decorator.Decorators
{
    internal class SMSNotifierDecorator : NotifierDecorator
    {
        private string PhoneNumber { get; set; }
        public SMSNotifierDecorator(INotifier notifier, string phoneNumber) : base(notifier)
        {
            PhoneNumber = phoneNumber;
            SendSMS();
        }

        private void SendSMS()
        {
            Console.WriteLine($"Sending SMS to {this.PhoneNumber}");
            Console.WriteLine("Your latest operation was executed successfully");
        }
    }
}
