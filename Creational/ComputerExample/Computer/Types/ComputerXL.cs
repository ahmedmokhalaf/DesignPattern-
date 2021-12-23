namespace DesignPattern.Creational.ComputerExample.Computer.Types
{
    class ComputerXL : Computer, ICoolingSystem, IPower
    {
        private CoolingSystem CS;
        private UPS Ups;

        public CoolingSystem SetCS(CoolingSystem coolingSystem) => CS = coolingSystem;
        public UPS SetUps(UPS ups) => Ups = ups;

        public bool BackupPower()
        {
            //
            return true;
        }

        public bool CoolDown(int Temp)
        {
            return true;
        }

        public override bool turnOff()
        {
            return true;
        }

        public override bool turnOn()
        {
            return true;
        }
    }
}
