using DesignPattern.Creational.FactoryMethod.DialogExample.Buttons;

namespace DesignPattern.Creational.FactoryMethod.DialogExample.Dialogs
{
    class SystemDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new SystemButton();
        }
    }
}
