namespace DesignPattern.Structural.Decorator
{
    internal class EmailNotifier : INotifier
    {
        private string Email;

        public EmailNotifier(string email)
        {
            Email = email;
        }

        public void Notify()
        {
            Console.WriteLine($"Sending email to: {this.Email}");
            Console.WriteLine($"Your latest operation was executed successfully");
        }
    }
}
