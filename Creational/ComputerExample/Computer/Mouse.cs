using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer
{
    class Mouse
    {
        private bool WithExtraUtilities;

        public Mouse(bool withExtraUtilities)
        {
            WithExtraUtilities = withExtraUtilities;
        }

        public bool IswithExtraUtilities() => WithExtraUtilities;
    }
}
