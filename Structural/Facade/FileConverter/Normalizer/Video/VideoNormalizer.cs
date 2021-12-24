using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.FileConverter.Normalizer.Audio
{
    internal class VideoNormalizer : INormalizer
    {
        public void Normalize(string filename)
        {
            Console.WriteLine($"I am normalizing the file {filename} due to some data corruption\n");
        }
    }
}
