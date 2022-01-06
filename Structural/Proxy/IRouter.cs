namespace DesignPattern.Structural.Proxy
{
    interface IRouter
    {
        public bool Resolve(string url);
        public void Stream();
    }
}
