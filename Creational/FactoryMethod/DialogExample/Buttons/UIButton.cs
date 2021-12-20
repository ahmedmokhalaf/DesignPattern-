using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.FactoryMethod.DialogExample.Buttons
{
    class UIButton : Button
    {
        public override void Click()
        {
            Console.WriteLine("UI Button Clicked");
        }

        public override string Show()
        {
            return "SHOW :  UI Button";
        }
    }
}
