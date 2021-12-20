using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts
{
    class GPU
    {
        private int Size;

        public GPU(int size)
        {
            Size = size;
        }
        public int GetSize() => Size;
    }
}
