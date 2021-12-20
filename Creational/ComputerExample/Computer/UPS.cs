using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer
{
    class UPS
    {
        private bool Duration;

        public UPS(bool duration)
        {
            Duration = duration;
        }

        public bool IsDuration() => Duration;
    }
}
