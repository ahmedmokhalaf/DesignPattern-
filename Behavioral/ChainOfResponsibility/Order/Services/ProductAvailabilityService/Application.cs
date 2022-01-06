namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Services.ProductAvailabilityService
{
    internal class Application
    {
        public Dictionary<string, int> ProductsAvailability = new Dictionary<string, int>()
            {
            {"PRD-1", 10},
            {"PRD-2", 73},
            {"PRD-3", 0}
            };
        public bool IsProductsAvailability(Product product)
        {
            return ProductsAvailability.GetValueOrDefault(product.Id) > 0;
        }
    }
}
