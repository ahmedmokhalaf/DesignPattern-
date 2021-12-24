using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.FileConverter.Converter
{
    internal interface IConverter
    {
        public void Convert(string FileName, string From, string To);
    }
}
