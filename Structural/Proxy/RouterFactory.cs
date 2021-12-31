using DesignPattern.Structural.Proxy.RoutingComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Proxy
{
    static class RouterFactory
    {
        public static IRouter CreateRouter()
        {
            List<Route> routes = new()
            {
                new Route("http://www.google.com", "152.233.22.1"),
                new Route("http://www.abc.com", "93.23.2.232"),
                new Route("http://www.xyz.com", "18.87.198.1"),
            };
            RoutingTable table = new RoutingTable(routes);
            Firewall firewall = new Firewall();
            ConnectionManager connectionManager = new ConnectionManager();

            return new Router(connectionManager, table, firewall);
        }
    }

}
