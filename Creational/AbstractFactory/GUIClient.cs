using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    class GUIClient
    {
        private IFormFactory Factory;

        public GUIClient(IFormFactory factory)
        {
            Factory = factory;
        }

        public void SetFactory(IFormFactory factory)
        {
            Factory = factory ;
        }

        public string CreateForm()
        {
            var Window = this.Factory.CreateWindow();
            Window.SetComponents(this.Factory.CreateTextInput());
            Window.SetComponents(this.Factory.CreateTextArea());
            Window.SetComponents(this.Factory.CreateButton());
            return Window.wRender();
        }
    }
}
