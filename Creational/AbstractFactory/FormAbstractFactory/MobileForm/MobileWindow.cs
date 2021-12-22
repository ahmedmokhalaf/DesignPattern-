using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.MobileForm
{
    internal class MobileWindow : AbstractWindow
    {
        public MobileWindow(string size) : base(size)
        {
        }

        public override string onClose()
        {
            return "Thank you for your feedback.\n";
        }

        public override string onResize()
        {
            return $"The window has new size {Size}\n";
        }
    }
}
