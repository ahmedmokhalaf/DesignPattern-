using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer
{
    class Monitor
    {
        private string Resolution;

        public Monitor(string resolution)
        {
            Resolution = resolution;
        }

        public string GetResolution() => Resolution;
    }
}
