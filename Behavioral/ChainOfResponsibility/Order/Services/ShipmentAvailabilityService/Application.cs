namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Services.ShipmentAvailabilityService
{
    internal class Application
    {


        private Dictionary<string, DateOnly> ShipmentAvailability = new Dictionary<string, DateOnly>() {
            {"TRK-1" ,  new DateOnly(2020, 07,01) },
            {"TRK-2", new DateOnly(2020,07,23) },
            {"TRK-3", new DateOnly(2020,10,13) }
        };
        public bool HasShipmentTruckAvailable(Order order) =>
            ShipmentAvailability.ContainsValue(order.ShipmentDate) ? true : false;
    }
}
