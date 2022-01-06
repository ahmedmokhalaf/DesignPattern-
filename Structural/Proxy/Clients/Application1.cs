namespace DesignPattern.Structural.Proxy.Clients
{
    class Application1 : Application
    {
        public DateOnly InitializedAt { get; private set; }
        public Application1(DateOnly initializedAt, string appName = "APP_1") : base(appName)
        {
            InitializedAt = initializedAt;
        }
    }
}
