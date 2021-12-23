namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.WebForm
{
    internal class WebTextArea : AbstractTextArea, IRenderable
    {
        public WebTextArea(string name, string text) : base(name, text)
        {
        }

        public override string onResize()
        {
            return $"The text area {this.Name} has been resized\n";
        }

        public string Render()
        {
            return "Web Text Area";
        }
    }
}
