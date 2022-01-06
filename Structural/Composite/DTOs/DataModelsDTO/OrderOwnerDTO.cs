namespace DesignPattern.Structural.Composite.DTOs.DataModelsDTO
{
    internal class OrderOwnerDTO : IDTOModel
    {
        public string Name { get; private set; }
        public AddressDTO Address { get; private set; }

        public OrderOwnerDTO(string name, AddressDTO address)
        {
            Name = name;
            Address = address;
        }

        public string[] Render()
        {
            return new string[] { Name, Address.Render().ToString() };
        }
    }
}
