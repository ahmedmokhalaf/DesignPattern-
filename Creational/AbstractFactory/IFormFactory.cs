namespace DesignPattern.Creational.AbstractFactory
{
    internal interface IFormFactory
    {
        public AbstractTextInput CreateTextInput();
        public AbstractTextArea CreateTextArea();
        public AbstractWindow CreateWindow();
        public AbstractButton CreateButton();
    }
}
