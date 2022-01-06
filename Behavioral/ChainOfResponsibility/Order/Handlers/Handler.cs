namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Handlers
{
    interface Handler
    {
        public void Handle(Order order);
        public Handler SetNextHandler(Handler nextHandler);
    }
}
