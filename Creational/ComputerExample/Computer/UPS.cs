namespace DesignPattern.Creational.ComputerExample.Computer
{
    class UPS
    {
        private bool Duration;

        public UPS(bool duration)
        {
            Duration = duration;
        }

        public bool IsDuration() => Duration;
    }
}
