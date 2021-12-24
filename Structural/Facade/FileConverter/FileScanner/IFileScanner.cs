using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.FileConverter.FileScanner
{
    public interface IFileScanner
    {        
        abstract public bool Scan();
    }
}
