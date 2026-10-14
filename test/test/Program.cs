using System;

// كلاس أساسي (Base Class)
class Person
{
    // Private field (مخفي داخل الكلاس فقط)
    private int age;

    // Property عادي مع منطق داخلي
    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("العمر لازم يكون أكبر من صفر");
        }
    }

    // Auto-Property (مختصر)
    public string Name { get; set; }

    // Protected member (مخفي لكن متاح للوراثة)
    protected string Address { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// كلاس يرث من Person
class Student : Person
{
    public string Major { get; set; }

    // الوصول للـ Protected من الكلاس الأب
    public void SetAddress(string addr)
    {
        Address = addr;
    }

    public void PrintStudentInfo()
    {
        PrintInfo(); // استدعاء من الأب
        Console.WriteLine($"Major: {Major}, Address: {Address}");
    }
}

// Sealed class (ما بسمح لأي كلاس يرث منه)
sealed class Teacher : Person
{
    public string Subject { get; set; }

    public void PrintTeacherInfo()
    {
        PrintInfo();
        Console.WriteLine($"Subject: {Subject}");
    }
}

class Program
{
    static void Main()
    {
        // استخدام Student
        Student s = new Student();
        s.Name = "Nada";       // Auto-Property
        s.Age = 23;            // Property مع منطق داخلي
        s.Major = "Computer Engineering";
        s.SetAddress("Irbid - Jordan");
        s.PrintStudentInfo();

        Console.WriteLine("---------------");

        // استخدام Teacher (Sealed class)
        Teacher t = new Teacher();
        t.Name = "Ahmad";
        t.Age = 40;
        t.Subject = "Mathematics";
        t.PrintTeacherInfo();
    }
}