using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Proxy
{
   interface IRouter
   {
        public bool Resolve(string url);
        public void Stream();
   }
}
