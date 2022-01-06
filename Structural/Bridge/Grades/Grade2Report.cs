using DesignPattern.Bridge.Structural.Reports;

namespace DesignPattern.Bridge.Structural.Grades
{
    internal class Grade2Report : GradeReport
    {
        public Grade2Report(ReportBridge report) : base(report)
        {
        }

        public override string ShowReport()
        {
            return Report.showGrade2Report();
        }
    }
}
