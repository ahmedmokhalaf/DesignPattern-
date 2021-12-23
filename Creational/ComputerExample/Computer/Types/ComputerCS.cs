namespace DesignPattern.Creational.ComputerExample.Computer.Types
{
    class ComputerCS : Computer, ICoolingSystem
    {
        private CoolingSystem CS;

        public CoolingSystem SetCS(CoolingSystem coolingSystem) => CS = coolingSystem;

        public bool CoolDown(int Temp)
        {
            //throw new NotImplementedException();
            return true;
        }

        public override bool turnOff()
        {
            //throw new NotImplementedException();
            return true;
        }

        public override bool turnOn()
        {
            //throw new NotImplementedException();
            return true;
        }
    }
}
