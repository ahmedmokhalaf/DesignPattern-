namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Services.OrderService
{
    internal class Application
    {
        public List<Order> Orders { get; private set; } = new List<Order>();

        public void AddOrder(Order order) => Orders.Add(order);

    }
}
