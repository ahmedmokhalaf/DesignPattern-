using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    internal interface IFormFactory
    {
        public AbstractTextInput CreateTextInput();
        public AbstractTextArea CreateTextArea();
        public AbstractWindow CreateWindow();
        public AbstractButton CreateButton();
    }
}
