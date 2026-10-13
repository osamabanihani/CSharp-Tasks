using System;

namespace SchoolSystem
{
    sealed class SchoolReport
    {
        public string ReportTitle { get; set; }

        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }

        public void DisplayReportTitle()
        {
            Console.WriteLine("Report: " + ReportTitle);
        }
    }

    // No class can inherit from SchoolReport because it is sealed.
}
