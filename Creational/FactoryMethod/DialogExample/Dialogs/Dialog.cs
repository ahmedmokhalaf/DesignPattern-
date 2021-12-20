using DesignPattern.Creational.FactoryMethod.DialogExample.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
