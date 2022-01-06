namespace DesignPattern.Structural.Proxy.Clients
{
    class Application
    {
        protected string AppName;

        public Application(string appName)
        {
            AppName = appName;
        }

        public string GetAppName() => AppName;
    }
}
