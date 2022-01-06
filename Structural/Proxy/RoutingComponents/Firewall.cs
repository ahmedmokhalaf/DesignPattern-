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
