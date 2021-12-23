using DesignPattern.Creational.FactoryMethod.DialogExample.Buttons;

namespace DesignPattern.Creational.FactoryMethod.DialogExample.Dialogs
{
    abstract class Dialog
    {
        abstract public Button CreateButton();

        public string RenderDialog()
        {
            Button button = CreateButton();
            return $"" + $"########################\n" + $" { button.Show() } \n" + $"########################\n";
        }
    }
}
