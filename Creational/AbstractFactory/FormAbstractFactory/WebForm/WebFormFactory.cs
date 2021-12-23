namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.WebForm
{
    internal class WebFormFactory : IFormFactory
    {
        public AbstractButton CreateButton()
        {
            return new WebButton();
        }

        public AbstractTextArea CreateTextArea()
        {
            return new WebTextArea("Web Text Area", "Enter your message...");
        }

        public AbstractTextInput CreateTextInput()
        {
            return new WebTextInput("Web Input", "Enter your name:", "Ahmed");
        }

        public AbstractWindow CreateWindow()
        {
            return new WebWindow("1920x1080");
        }
    }
}
