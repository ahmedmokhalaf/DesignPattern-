using DesignPattern.Bridge.Structural.Reports;

namespace DesignPattern.Structural.Bridge.Reports
{
    internal class XHTMLReport : ReportBridge
    {
        public string showGrade1Report()
        {
            return "<Student>This is a grade 1 report</Student>\n";
        }

        public string showGrade2Report()
        {
            return "<Student>This is a grade 2 report</Student>\n";
        }

        public string showGrade3Report()
        {
            return "<Student>This is a grade 3 report</Student>\n";
        }
    }
}
