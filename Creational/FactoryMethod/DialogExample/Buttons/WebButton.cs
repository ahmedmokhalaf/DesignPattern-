using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.FactoryMethod.DialogExample.Buttons
{
    class WebButton : Button
    {
        public override void Click()
        {
            Console.WriteLine("Web Button Clicked");
        }

        public override string Show()
        {
            return "SHOW :  Web Button";
        }
    }
}
