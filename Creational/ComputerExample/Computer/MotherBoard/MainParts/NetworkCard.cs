using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts
{
    class NetworkCard
    {
        private int Category;

        public NetworkCard(int category)
        {
            Category = category;
        }

        public int GetCategory() => Category;
    }
}
