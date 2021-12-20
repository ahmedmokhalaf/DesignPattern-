using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer
{
    class CoolingSystem
    {
        private int LowTempLimit;

        public CoolingSystem(int lowTempLimit)
        {
            LowTempLimit = lowTempLimit;
        }
        public int IsCoolingDown() => LowTempLimit;
    }
}
