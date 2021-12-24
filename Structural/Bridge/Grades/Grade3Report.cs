using DesignPattern.Bridge.Structural.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Structural.Grades
{
    internal class Grade3Report : GradeReport
    {
        public Grade3Report(ReportBridge report) : base(report)
        {
        }

        public override string ShowReport()
        {
            return Report.showGrade3Report();
        }
    }
}
