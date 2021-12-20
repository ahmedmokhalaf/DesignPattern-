using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer
{
    class Keyboard
    {
        private bool UtfSupport;

        public Keyboard(bool utfSupport)
        {
            UtfSupport = utfSupport;
        }

        public bool IsUtfSupport() => UtfSupport;
    }
}
