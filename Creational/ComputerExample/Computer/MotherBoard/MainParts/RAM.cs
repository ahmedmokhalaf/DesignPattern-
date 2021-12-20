using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts
{
    class RAM
    {
        private int Size;

        public RAM(int size)
        {
            Size = size;
        }

        public int GetSize() => Size;  
    }
}
