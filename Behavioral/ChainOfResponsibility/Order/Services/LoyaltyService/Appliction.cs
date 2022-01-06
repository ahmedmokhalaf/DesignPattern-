namespace DesignPattern.Behavioral.ChainOfResponsibility.Order.Services.LoyaltyService
{
    internal class Appliction
    {
        private Dictionary<string, int> LoyaltyDirectory = new Dictionary<string, int>()
            {
                {"USR-100", 5 },
                {"USR-101" , 7 },
                {"USR-103" , 3}
            };

        public bool IsUserLoyal(User user)
        {
            return LoyaltyDirectory.GetValueOrDefault(user.Id) >= 5;
        }
    }
}
