using DesignPattern.Creational.FactoryMethod.DialogExample.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
