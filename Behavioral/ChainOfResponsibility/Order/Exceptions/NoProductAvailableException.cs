namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Exceptions
{
    internal class NoProductAvailableException : Exception
    {
        public NoProductAvailableException() : base()
        {
            throw new Exception("Sorry, the product is not available at the moment");
        }
    }
}
