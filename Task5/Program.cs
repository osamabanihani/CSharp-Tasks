using System;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("School Management System");
            Console.WriteLine();

            Student student1 = new Student("Osama", 23, "ABC School", 85, 101);
            Student student2 = new Student("Sara", 19, "ABC School", 92, 102);
            Teacher teacher1 = new Teacher("Ahmad", 35, "ABC School", "Math");

            Console.WriteLine("Students");
            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();

            Console.WriteLine(" Teacher ");
            teacher1.DisplayTeacherInfo();

            SchoolReport report1 = new SchoolReport("Final School Report");
            Console.WriteLine("School Report");
            report1.DisplayReportTitle();

            // student1.SchoolName = "New School";
            // Error: SchoolName is protected, not accessible from Main.

            // student1._internalCode = "999";
            // Error: _internalCode is private to Person.
        }
    }
}
