using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts
{
    class CPU
    {
        private float Speed;

        public CPU(float speed)
        {
            Speed = speed;
        }

        public float GetSpeed() => Speed; 
    }
}
