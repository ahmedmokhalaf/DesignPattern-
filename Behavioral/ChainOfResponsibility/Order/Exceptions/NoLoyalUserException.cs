namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Exceptions
{
    internal class NoLoyalUserException : Exception
    {
        public NoLoyalUserException() : base()
        {
            throw new Exception("Sorry, you do not have required points to place the order");
        }
    }
}
