namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.DesktopForm
{
    internal class DesktopTextArea : AbstractTextArea, IRenderable
    {
        public DesktopTextArea(string name, string text) : base(name, text)
        {
        }

        public override string onResize()
        {
            return $"The text area {this.Name} has been resized\n";
        }

        public string Render()
        {
            return "Desktop Text Area";
        }
    }
}
