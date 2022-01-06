using DesignPattern.Bridge.Structural.Reports;

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
