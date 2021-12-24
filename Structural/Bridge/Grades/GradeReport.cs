using DesignPattern.Bridge.Structural.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Structural.Grades
{
    abstract class GradeReport
    {
        protected ReportBridge Report { get; set; }
        protected GradeReport(ReportBridge report)
        {
            Report = report;
        }
        abstract public string ShowReport();
        public void SetReport (ReportBridge report)
        {
            Report = report;
        }
    }
}
