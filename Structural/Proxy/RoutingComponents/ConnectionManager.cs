using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Proxy.RoutingComponents
{
    class ConnectionManager
    {
        public void ConnectTo(string ipAddress)
        {
            Console.WriteLine($"Connecting to {ipAddress}");
        }

        public void terminate()
        {
            Console.WriteLine("Disconnecting...");
        }
    }
}
