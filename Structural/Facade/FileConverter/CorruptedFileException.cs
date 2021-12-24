using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Exception;

namespace DesignPattern.Structural.Facade.FileConverter
{
    public class CorruptedFileException : Exception
    {
        public CorruptedFileException(string? message) : base(message)
        {
        }
    }
}
