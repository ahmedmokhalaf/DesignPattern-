namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.WebForm
{
    internal class WebWindow : AbstractWindow
    {
        public WebWindow(string size) : base(size)
        {
        }

        public override string onClose()
        {
            return "Thank you for your feedback.\n";
        }

        public override string onResize()
        {
            return $"The window has new size {Size}\n";
        }
    }
}
