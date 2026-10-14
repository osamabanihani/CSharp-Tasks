using System;

namespace SchoolSystem
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected string SchoolName { get; set; }
        private string _internalCode = "12345";

        // _internalCode is private so it is only accessible inside Person.
        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
