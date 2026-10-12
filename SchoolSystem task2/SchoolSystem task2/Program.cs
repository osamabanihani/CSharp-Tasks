using System;

namespace OOPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =====================================
            // 1. CLASS VS OBJECT
            // =====================================

            // Class: A blueprint used to create objects.
            // Object: An instance of a class.
            // Student is our class.

            // =====================================
            // 2. CREATING AN OBJECT
            // =====================================

            // new creates an object.
            // Student() calls the constructor.
            // student1 is a reference to the object.

            Student student1 = new Student();

            // Accessing fields using the dot (.) operator
            student1.Name = "Yasmeen";
            student1.Age = 22;
            student1.Grade = 90;

            Console.WriteLine("FIRST STUDENT");
            Console.WriteLine($"Name: {student1.Name}");
            Console.WriteLine($"Age: {student1.Age}");
            Console.WriteLine($"Grade: {student1.Grade}");

            // =====================================
            // 3. CREATING MULTIPLE OBJECTS
            // =====================================

            // We can create multiple objects
            // from the same class.
            // Each object has its own data.

            Student student2 = new Student();
            student2.Name = "Sara";
            student2.Age = 21;
            student2.Grade = 95;

            Student student3 = new Student();
            student3.Name = "Ahmad";
            student3.Age = 23;
            student3.Grade = 85;

            Console.WriteLine("\nSECOND STUDENT");
            Console.WriteLine($"Name: {student2.Name}");
            Console.WriteLine($"Age: {student2.Age}");
            Console.WriteLine($"Grade: {student2.Grade}");

            Console.WriteLine("\nTHIRD STUDENT");
            Console.WriteLine($"Name: {student3.Name}");
            Console.WriteLine($"Age: {student3.Age}");
            Console.WriteLine($"Grade: {student3.Grade}");

            // =====================================
            // 4. PARAMETERIZED CONSTRUCTOR
            // =====================================

            // Instead of assigning values separately,
            // we can pass them to the constructor.

            Student student4 = new Student("Marwa", 22, 98);

            Console.WriteLine("\nFOURTH STUDENT");
            Console.WriteLine($"Name: {student4.Name}");
            Console.WriteLine($"Age: {student4.Age}");
            Console.WriteLine($"Grade: {student4.Grade}");

            // =====================================
            // 5. CALLING A METHOD
            // =====================================

            // Methods define what an object can do.
            // DisplayInfo() belongs to the Student class.

            Console.WriteLine("\nSTUDENT INFORMATION");
            student4.DisplayInfo();
        }
    }

    // =====================================
    // STUDENT CLASS
    // =====================================

    // A class contains fields, constructors,
    // and methods.

    class Student
    {
        // =====================================
        // FIELDS
        // =====================================

        // Fields store data about an object.
        // public means they can be accessed
        // from other classes.

        public string Name;
        public int Age;
        public double Grade;

        // =====================================
        // PARAMETERLESS CONSTRUCTOR
        // =====================================

        // A constructor has the same name
        // as its class.
        // It does not have a return type.
        // It runs automatically when using new.

        public Student()
        {
            Name = "Unknown";
            Age = 0;
            Grade = 0;
        }

        // =====================================
        // PARAMETERIZED CONSTRUCTOR
        // =====================================

        // This constructor receives values
        // when an object is created.

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // =====================================
        // METHOD
        // =====================================

        // A method defines an action
        // that an object can perform.

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}