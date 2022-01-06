namespace DesignPattern.Structural.Composite.DTOs.DataModelsDTO
{
    class OrderDTO : IDTOModel
    {
        public IDTOModel Owner { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public float Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderDTO(IDTOModel owner, DateTime createdAt, float price, int quantity)
        {
            Owner = owner;
            CreatedAt = createdAt;
            Price = price;
            Quantity = quantity;
        }


        public string[] Render()
        {

            return new string[] {
                CreatedAt.ToString("MM/dd/yyyy"),
                Price.ToString(),
                Quantity.ToString(),
                Owner.Render().ToString()
            };

        }
    }
}
