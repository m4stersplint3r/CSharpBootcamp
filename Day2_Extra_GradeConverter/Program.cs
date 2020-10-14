using System;

namespace Day2_Extra_GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            bool toContinue = true;

            Console.WriteLine("Welcome to the Letter Grade Converter!");

            while (toContinue)
            {
                Console.Write("Enter a numerical grade: ");
                userInput = int.Parse(Console.ReadLine());


                switch (userInput)
                {
                    case int x when x <= 100 && x >= 88:
                        Console.WriteLine("A");
                        break;
                    case int x when x <= 87 && x >= 80:
                        Console.WriteLine("B");
                        break;
                    case int x when x <= 79 && x >= 67:
                        Console.WriteLine("C");
                        break;
                    case int x when x <= 66 && x >= 60:
                        Console.WriteLine("D");
                        break;
                    case int x when x <= 60:
                        Console.WriteLine("F");
                        break;
                }

                Console.WriteLine("Would you like to continue? (y/n)");
                if (!(Console.ReadLine().ToLower().Trim() == "y"))
                    toContinue = false;
            }
            Console.WriteLine("Thanks for grading!");
        }
    }
}
