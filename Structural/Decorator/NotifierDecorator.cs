namespace DesignPattern.Structural.Decorator
{
    internal class NotifierDecorator : INotifier
    {
        protected INotifier Notifier { get; set; }

        public NotifierDecorator(INotifier notifier)
        {
            this.Notifier = notifier;
        }

        public void Notify()
        {
            this.Notifier.Notify();
        }
    }
}
