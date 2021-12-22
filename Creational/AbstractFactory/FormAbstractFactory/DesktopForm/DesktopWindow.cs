using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.DesktopForm
{
    internal class DesktopWindow : AbstractWindow
    {
        public DesktopWindow(string size) : base(size)
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
