using DesignPattern.Behavioral.ChainOfResponsibility.Order.Exceptions;
using DesignPattern.Behavioral.ChainOfResponsibility.Order.Services.LoyaltyService;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Handlers
{
    internal class LoyaltyHandler : BaseHandler
    {
        public override void Handle(Order order)
        {
            Appliction appliction = new Appliction();
            if (appliction.IsUserLoyal(order.User))
            {
                if (this.NextHandler != null)
                {
                    this.NextHandler.Handle(order);
                }
            }
            else
            {
                throw new NoLoyalUserException();
            }
        }
    }
}
