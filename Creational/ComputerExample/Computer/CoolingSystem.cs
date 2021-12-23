namespace DesignPattern.Creational.ComputerExample.Computer
{
    class CoolingSystem
    {
        private int LowTempLimit;

        public CoolingSystem(int lowTempLimit)
        {
            LowTempLimit = lowTempLimit;
        }
        public int IsCoolingDown() => LowTempLimit;
    }
}
