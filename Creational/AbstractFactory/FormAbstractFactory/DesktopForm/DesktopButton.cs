namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.DesktopForm
{
    internal class DesktopButton : AbstractButton, IRenderable
    {
        public override string OnClick()
        {
            return "The button has been clicked\n";
        }

        public string Render()
        {
            return "Desktop Button";
        }
    }
}
