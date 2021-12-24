using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.FileConverter.Converter.Audio
{
    internal class AudioConverter : IConverter
    {
        public void Convert(string FileName, string From, string To)
        {
            Console.WriteLine($"I am converting audio file {FileName} from {From} to {To}\n");
        }
    }
}
