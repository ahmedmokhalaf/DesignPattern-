using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Proxy.RoutingComponents
{
    class Route
    {

        public string URL { get; private set; }
        public string  IpAddress { get; private set; }
        
        public Route(string url, string ipAddress)
        {
            URL = url;
            IpAddress = ipAddress;
        }
    }
}
