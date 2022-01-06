using DesignPattern.Structural.Proxy.RoutingComponents;

namespace DesignPattern.Structural.Proxy
{
    class Router : IRouter
    {

        public ConnectionManager connectionManager { get; private set; }
        public RoutingTable Table { get; private set; }
        public Firewall firewall { get; private set; }

        public Router(ConnectionManager connectionManager, RoutingTable table, Firewall firewall)
        {
            this.connectionManager = connectionManager;
            Table = table;
            this.firewall = firewall;
        }

        public bool Resolve(string url)
        {
            Route route = Table.MapUrlToIPAddress(url);
            if (route is not null)
            {
                Connect(route.URL);
                return true;
            }
            Console.WriteLine("Route was not found");
            return false;
        }

        private void Connect(string ipAddress)
        {
            this.connectionManager.ConnectTo(ipAddress);
        }

        public void Stream()
        {
            string[] packets = {
                "Package one is clean",
                "Package two is clean",
                "Package three is __BAD__",
                "Package four is __BAD__",
            };

            foreach (string packet in packets)
            {
                if (firewall.isValidPacket(packet))
                {
                    Console.WriteLine($"{packet}");
                }
                else
                {
                    Console.WriteLine("Dropping a packet");
                }
            }

            terminate();
        }

        private void terminate()
        {
            connectionManager.terminate();
        }
    }
}
