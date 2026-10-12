using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(50, 76);
            int guess = 0;
            int attempts = 0;
            int points;

            Console.WriteLine(" Guessing Game ");

            while (guess != number)
            {
                Console.Write("Guess a number between 50 and 75: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < number)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Try a lower number.");
                }
            }

            if (attempts == 1)
            {
                points = 10;
            }
            else if (attempts == 2)
            {
                points = 7;
            }
            else if (attempts == 3)
            {
                points = 5;
            }
            else
            {
                points = 0;
            }

            Console.WriteLine("Congratulations!");
            Console.WriteLine("Attempts: " + attempts);
            Console.WriteLine("Points: " + points);
            
            string[] students = { "Ahmad", "Sara", "Osama", "Lina", "Yazan" };
            int[] grades = { 85, 92, 68, 75, 90 };
            int choice;

            do
            {
                Console.WriteLine("School System ");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Students:");

                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }

                        Console.WriteLine("Grades:");

                        foreach (int studentGrade in grades)
                        {
                            Console.WriteLine(studentGrade);
                        }
                        break;

                    case 2:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        int index = 0;
                        bool found = false;

                        while (index < students.Length)
                        {
                            if (students[index].ToLower() == name.ToLower())
                            {
                                Console.WriteLine("Student Found!");
                                found = true;
                                break;
                            }

                            index++;
                        }

                        if (!found)
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter student grade: ");
                        int grade = Convert.ToInt32(Console.ReadLine());

                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Invalid grade.");
                        }
                        else if (grade >= 90)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (grade >= 80)
                        {
                            Console.WriteLine("Very Good");
                        }
                        else if (grade >= 70)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (grade >= 50)
                        {
                            Console.WriteLine("Pass");
                        }
                        else
                        {
                            Console.WriteLine("Fail");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            while (choice != 4);
        }
    }
}