namespace DesignPattern.Bridge.Structural.Reports
{
    internal class PlainTextReport : ReportBridge
    {
        public string showGrade1Report()
        {
            return "This is a grade 1 report\n";
        }

        public string showGrade2Report()
        {
            return "This is a grade 2 report\n";
        }

        public string showGrade3Report()
        {
            return "This is a grade 3 report\n";
        }
    }
}
