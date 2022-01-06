namespace DesignPattern.Behavioral.ChainOfResponsibility.Order
{
    internal class Product
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        public Product(string id, string name)
        {
            Id = id;
            Name = name;
        }


    }
}
