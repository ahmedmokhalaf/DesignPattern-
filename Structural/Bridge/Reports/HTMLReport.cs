using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Structural.Reports
{
    internal class HTMLReport : ReportBridge
    {
        public string showGrade1Report()
        {
            return "<h1>This is a grade 1 report</h1>\n";
        }

        public string showGrade2Report()
        {
            return "<h1>This is a grade 2 report</h1>\n";
        }

        public string showGrade3Report()
        {
            return "<h1>This is a grade 3 report</h1>\n";
        }
    }
}
