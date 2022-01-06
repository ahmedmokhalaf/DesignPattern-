namespace DesignPattern.Behavioral.ChainOfResponsibility.Order
{
    internal class User
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
