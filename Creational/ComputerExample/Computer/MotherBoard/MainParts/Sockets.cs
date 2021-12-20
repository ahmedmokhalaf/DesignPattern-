using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
