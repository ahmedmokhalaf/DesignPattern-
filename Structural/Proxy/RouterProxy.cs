using DesignPattern.Structural.Proxy.Clients;

namespace DesignPattern.Structural.Proxy
{
    internal class RouterProxy : IRouter
    {

        public IRouter Router { get; private set; }
        public Application application { get; private set; }
        public string[] ACL { get; private set; }

        public RouterProxy(IRouter router, Application application, string[] acl)
        {
            Router = router;
            this.application = application;
            ACL = acl;
        }

        public bool Resolve(string url)
        {
            if (IsAllowedApplication())
            {
                return Router.Resolve(url);
            }
            else
            {
                Console.WriteLine("This application can not use the router");
            }
            return false;
        }

        public void Stream()
        {
            if (IsAllowedApplication())
            {
                Router.Stream();
            }
            else
            {
                Console.WriteLine("This application can not use the router");
            }
        }

        private bool IsAllowedApplication()
        {
            return ACL.Contains(application.GetAppName());
        }
    }
}
