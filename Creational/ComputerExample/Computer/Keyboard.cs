namespace DesignPattern.Creational.ComputerExample.Computer
{
    class Keyboard
    {
        private bool UtfSupport;

        public Keyboard(bool utfSupport)
        {
            UtfSupport = utfSupport;
        }

        public bool IsUtfSupport() => UtfSupport;
    }
}
