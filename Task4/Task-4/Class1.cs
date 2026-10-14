using System;


class Person
{
    public string Name { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}


    sealed class Teacher : Person
    {
    public string Subject { get; set; }

    public void PrintTeacherInfo()
    {
        PrintInfo();
        Console.WriteLine($"Subject: {Subject}");
    }
    }

// لو حاولنا نعمل وراثة من Teacher رح يطلع Error
    class MathTeacher : Teacher
    {
    }

