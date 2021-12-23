namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts
{
    class NetworkCard
    {
        private int Category;

        public NetworkCard(int category)
        {
            Category = category;
        }

        public int GetCategory() => Category;
    }
}
