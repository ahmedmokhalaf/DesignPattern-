using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts
{
    class Disk
    {
        private string Type;

        public Disk(string type)
        {
            Type = type;
        }

        public string getType() => Type;
    }
}
