namespace DesignPattern.Creational.ComputerExample.Computer
{
    class Monitor
    {
        private string Resolution;

        public Monitor(string resolution)
        {
            Resolution = resolution;
        }

        public string GetResolution() => Resolution;
    }
}
