using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.WebForm
{
    internal class WebButton : AbstractButton, IRenderable
    {
        public override string OnClick()
        {
            return "The button has been clicked\n";
        }

        public string Render()
        {
            return "Web Button";
        }
    }
}
