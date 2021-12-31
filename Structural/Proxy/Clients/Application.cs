using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Proxy.Clients
{
    class Application
    {
        protected string AppName;

        public Application(string appName)
        {
            AppName = appName;
        }

        public string GetAppName() => AppName;
    }
}
