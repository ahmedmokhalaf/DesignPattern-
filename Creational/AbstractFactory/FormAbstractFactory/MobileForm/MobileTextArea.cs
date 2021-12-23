namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.MobileForm
{
    internal class MobileTextArea : AbstractTextArea, IRenderable
    {
        public MobileTextArea(string name, string text) : base(name, text)
        {
        }

        public override string onResize()
        {
            return $"The text area {this.Name} has been resized\n";
        }

        public string Render()
        {
            return "Mobile Text Area";
        }
    }
}
