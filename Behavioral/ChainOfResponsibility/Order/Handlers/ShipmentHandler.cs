using DesignPattern.Behavioral.ChainOfResponsibility.Order.Exceptions;
using DesignPattern.Behavioral.ChainOfResponsibility.Order.Services.ShipmentAvailabilityService;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Handlers
{
    internal class ShipmentHandler : BaseHandler
    {
        public override void Handle(Order order)
        {
            Application application = new Application();
            if (application.HasShipmentTruckAvailable(order))
            {
                if (this.NextHandler != null)
                {
                    this.NextHandler.Handle(order);
                }
            }
            else
            {
                throw new NoShipmentAvailableException();
            }
        }
    }
}
