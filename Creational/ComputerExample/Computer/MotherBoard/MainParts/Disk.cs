namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts
{
    class Disk
    {
        private string Type;

        public Disk(string type)
        {
            Type = type;
        }

        public string getType() => Type;
    }
}
