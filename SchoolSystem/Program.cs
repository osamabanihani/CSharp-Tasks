using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            double result1 = number;

            Console.WriteLine(result1);


            double price = 20.8;

            int result2 = (int)price;
            int result3 = Convert.ToInt32(price);

            Console.WriteLine(result2);
            Console.WriteLine(result3);


            Console.Write("Enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is " + age);
        }
    }
}