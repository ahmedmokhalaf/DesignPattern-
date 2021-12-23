namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.DesktopForm
{
    internal class DesktopFormFactory : IFormFactory
    {
        public AbstractButton CreateButton()
        {
            return new DesktopButton();
        }

        public AbstractTextArea CreateTextArea()
        {
            return new DesktopTextArea("Desktop Text Area", "Enter your message...");
        }

        public AbstractTextInput CreateTextInput()
        {
            return new DesktopTextInput("Desktop Input", "Enter your name:", "");
        }

        public AbstractWindow CreateWindow()
        {
            return new DesktopWindow("1920x1080");
        }
    }
}
