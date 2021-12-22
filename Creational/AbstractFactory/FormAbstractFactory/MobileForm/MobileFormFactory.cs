using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory.FormAbstractFactory.MobileForm
{
    internal class MobileFormFactory : IFormFactory
    {
        public AbstractButton CreateButton()
        {
            return new MobileButton();
        }

        public AbstractTextArea CreateTextArea()
        {
            return new MobileTextArea("Mobile Text Area" ,"Enter your message...");
        }

        public AbstractTextInput CreateTextInput()
        {
            return new MobileTextInput("Mobile Input", "Enter your name:", "");
        }

        public AbstractWindow CreateWindow()
        {
            return new MobileWindow("320x700");
        }
    }
}
