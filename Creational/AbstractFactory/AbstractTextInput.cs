namespace DesignPattern.Creational.AbstractFactory
{
    abstract class AbstractTextInput
    {

        protected string Name { get; set; }
        protected string Label { get; set; }
        protected string Value { get; set; }

        protected AbstractTextInput(string name, string label, string value)
        {
            Name = name;
            Label = label;
            Value = value;
        }
        public abstract string OnChange();

    }
}