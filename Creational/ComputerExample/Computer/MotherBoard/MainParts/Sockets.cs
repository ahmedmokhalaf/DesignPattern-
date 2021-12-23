namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts
{
    class Sockets
    {
        private Array sockets;

        public Sockets(Array sockets)
        {
            this.sockets = sockets;
        }

        public Array GetSockets() => sockets;
    }
}
