namespace DesignPattern.Structural.Proxy.RoutingComponents
{
    class RoutingTable
    {
        private List<Route> Routes;
        public RoutingTable(List<Route> routes)
        {
            Routes = routes;
        }

        public Route? MapUrlToIPAddress(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                Route? route = Routes.FirstOrDefault((x) => x.URL == url);
                return route;
            }
            return null;
        }
    }
}
