using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    abstract class AbstractButton
    {
        protected string Value { get; set; }
        //{
        //    get { return this.Value; }
        //    set { this.Value = value; }
        //}

        public abstract string OnClick();
    }
}
