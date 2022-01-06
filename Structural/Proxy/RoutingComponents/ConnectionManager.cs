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
