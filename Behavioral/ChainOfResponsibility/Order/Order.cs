namespace DesignPattern.Behavioral.ChainOfResponsibility.Order
{
    internal class Order
    {
        public User User { get; private set; }
        public Product Product { get; private set; }
        public DateOnly ShipmentDate { get; private set; }

        public Order(User user, Product product, DateOnly shipmentDate)
        {
            User = user;
            Product = product;
            ShipmentDate = shipmentDate;
        }
    }
}
