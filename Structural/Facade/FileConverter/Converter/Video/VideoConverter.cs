using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.FileConverter.Converter.Video
{
    internal class VideoConverter : IConverter
    {
        public void Convert(string FileName, string From, string To)
        {
            Console.WriteLine($"I am converting Video file {FileName} from {From} to {To}\n");
        }
    }
}
