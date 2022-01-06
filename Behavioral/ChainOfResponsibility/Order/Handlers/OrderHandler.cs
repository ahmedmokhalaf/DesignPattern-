using DesignPattern.Behavioral.ChainOfResponsibility.Order.Services.OrderService;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Handlers
{
    internal class OrderHandler : BaseHandler
    {
        public override void Handle(Order order)
        {
            Application application = new Application();
            application.AddOrder(order);
            Console.WriteLine(@$" The order of {order.User.Name}  contains {order.Product.Name} and will be shipped by  {order.ShipmentDate}");
        }
    }
}
