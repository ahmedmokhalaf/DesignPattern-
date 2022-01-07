using DesignPattern.Behavioral.ChainOfResponsibility.Order;
using DesignPattern.Behavioral.ChainOfResponsibility.Order.Exceptions;
using DesignPattern.Behavioral.ChainOfResponsibility.Order.Handlers;

namespace DesignPattern.Behavioral
{
    public class BehavioralPattern
    {
        public static void ChainOfResponsibilityDesignPattern()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t ***    Behavioral Pattern    ***");
            Console.WriteLine("==============================================================================");
            Console.WriteLine("\t\t\t\t *** Chain Of Responsibility ***");
            Console.ResetColor();

            User user = new User("USR-101", "Ahmed");
            Product product = new Product("PRD-1", "Lenovo Laptop");
            Order order = new Order(user, product, new DateOnly(2020, 07, 01));
            LoyaltyHandler loyaltyHandler = new LoyaltyHandler();
            loyaltyHandler
                .SetNextHandler(new ProductAvailabilityHandler())
                .SetNextHandler(new ShipmentHandler())
                .SetNextHandler(new OrderHandler());
            //Console.WriteLine(JsonConvert.SerializeObject(loyaltyHandler, Formatting.Indented));

            try { loyaltyHandler.Handle(order); }
            catch (NoLoyalUserException e) { Console.WriteLine(e.Message); }
            catch (NoProductAvailableException e) { Console.WriteLine(e.Message); }
            catch (NoShipmentAvailableException e) { Console.WriteLine(e.Message); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine("==============================================================================");
        }
    }
}
