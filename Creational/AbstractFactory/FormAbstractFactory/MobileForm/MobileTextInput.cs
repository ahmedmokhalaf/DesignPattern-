namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.MobileForm
{
    internal class MobileTextInput : AbstractTextInput, IRenderable
    {
        public MobileTextInput(string name, string label, string value) : base(name, label, value)
        {
        }

        public override string OnChange()
        {
            return $"The value of the {Name} input was changed to {Value}\n";
        }

        public string Render()
        {
            return "Mobile Text Input";
        }
    }
}
