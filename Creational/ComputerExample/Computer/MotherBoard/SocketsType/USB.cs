namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.SocketsType
{
    class USB
    {
        private float Version;

        public USB(float version)
        {
            Version = version;
        }

        public float GetVersion() => Version;
    }
}
