using DesignPattern.Creational.FactoryMethod.DialogExample.Buttons;

namespace DesignPattern.Creational.FactoryMethod.DialogExample.Dialogs
{
    class UIDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new UIButton();
        }
    }
}
