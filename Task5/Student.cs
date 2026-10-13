using System;

namespace SchoolSystem
{
    class Student : Person
    {
        public int Grade { get; set; }
        public int StudentId { get; set; }

        public Student(string name, int age, string schoolName, int grade, int studentId)
            : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }

        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("School: " + SchoolName);
            Console.WriteLine();
        }
    }
}
