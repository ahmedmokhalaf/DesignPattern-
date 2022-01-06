namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Exceptions
{
    internal class NoShipmentAvailableException : Exception
    {
        public NoShipmentAvailableException() : base()
        {
            throw new Exception("Sorry, we do not ship at this time");
        }
    }
}
