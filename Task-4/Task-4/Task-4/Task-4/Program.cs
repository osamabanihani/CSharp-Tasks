using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine();

            Class1 student1 = new Class1("Ahmad", 20, 85);
            Class1 student2 = new Class1("Sara", 21, 92);
            Class1 student3 = new Class1("Omar", 19, 78);

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
    }
}