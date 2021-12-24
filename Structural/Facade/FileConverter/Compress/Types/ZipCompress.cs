using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.FileConverter.Compress.Types
{
    internal class ZipCompress : ICompress
    {
        public void Compress(string FileName)
        {
            Console.WriteLine("File has been compressed to a zip file\n");
        }
    }
}
