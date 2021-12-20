using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer.Types
{
    abstract class Computer
    {
        protected MotherBoard.MotherBoard _motherBoard;
        protected Keyboard _keyboard;
        protected Mouse _mouse;
        protected Monitor _monitor;

        public MotherBoard.MotherBoard SetMotherBoard(MotherBoard.MotherBoard motherBoard) => _motherBoard = motherBoard;
        public Keyboard SetKeyboard(Keyboard keyboard) => _keyboard = keyboard;
        public Mouse SetMouse(Mouse mouse) => _mouse = mouse;
        public Monitor SetMonitor(Monitor monitor) => _monitor = monitor;

        abstract public bool turnOn();
        abstract public bool turnOff();
    }
}
