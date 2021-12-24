using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Reports
{
    internal interface ReportBridge
    {
        public string showGrade1Report();
        public string showGrade2Report();
        public string showGrade3Report();
    }
}
