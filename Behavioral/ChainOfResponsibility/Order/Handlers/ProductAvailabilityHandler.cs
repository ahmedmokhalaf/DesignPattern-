using DesignPattern.Behavioral.ChainOfResponsibility.Order.Exceptions;
using DesignPattern.Behavioral.ChainOfResponsibility.Order.Services.ProductAvailabilityService;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Handlers
{
    internal class ProductAvailabilityHandler : BaseHandler
    {
        public override void Handle(Order order)
        {
            Application application = new Application();
            if (application.IsProductsAvailability(order.Product))
            {
                if (this.NextHandler != null)
                {
                    this.NextHandler.Handle(order);
                }
            }
            else
            {
                throw new NoProductAvailableException();
            }
        }
    }
}
