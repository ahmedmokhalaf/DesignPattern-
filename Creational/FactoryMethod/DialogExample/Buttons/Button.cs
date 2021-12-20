using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.FactoryMethod.DialogExample.Buttons
{
    abstract class Button
    {
        public abstract string  Show();
        public abstract void  Click();
    }
}
