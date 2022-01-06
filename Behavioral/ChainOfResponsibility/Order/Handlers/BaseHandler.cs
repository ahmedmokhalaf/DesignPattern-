namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Handlers
{
    abstract class BaseHandler : Handler
    {
        public Handler NextHandler { get; private set; }

        public abstract void Handle(Order order);
        public Handler SetNextHandler(Handler nextHandler)
        {
            this.NextHandler = nextHandler;
            return this.NextHandler;
        }
    }
}
