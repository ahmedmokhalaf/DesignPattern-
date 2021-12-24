using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.FileConverter.Compress
{
    internal interface ICompress
    {
        public void Compress(string FileName);
    }
}
