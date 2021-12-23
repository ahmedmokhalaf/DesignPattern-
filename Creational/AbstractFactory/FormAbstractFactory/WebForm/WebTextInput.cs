namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.WebForm
{
    class WebTextInput : AbstractTextInput, IRenderable
    {
        public WebTextInput(string name, string label, string value) : base(name, label, value)
        {
        }

        public override string OnChange()
        {
            return $"The value of the {Name} input was changed to {Value}\n";
        }

        public string Render()
        {
            return "Web Text Input";
        }
    }
}
