namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.DesktopForm
{
    class DesktopTextInput : AbstractTextInput, IRenderable
    {
        public DesktopTextInput(string name, string label, string value) : base(name, label, value)
        {
        }

        public override string OnChange()
        {
            return $"The value of the {Name} input was changed to {Value}\n";
        }

        public string Render()
        {
            return "Desktop Text Input";
        }
    }
}
