using DesignPattern.Creational.FactoryMethod.DialogExample.Buttons;

namespace DesignPattern.Creational.FactoryMethod.DialogExample.Dialogs
{
    class WebDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new WebButton();
        }
    }
}
