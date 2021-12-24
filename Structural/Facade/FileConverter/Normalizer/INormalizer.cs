using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.FileConverter.Normalizer
{
    internal interface INormalizer
    {
        public void Normalize(string filename);
    }
}
