using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Proxy.RoutingComponents
{
    class Firewall
    {
        public bool isValidPacket(string packet)
        {
            return packet.Contains("__BAD__");
        }
    }
}
