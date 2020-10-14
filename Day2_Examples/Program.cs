using System;

namespace Day2_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{i} is a number less than 10");
            //}


            //Fizz Buzz
            //Check every number from 1 to 100
            //1) if the number is divisible by 3, print Fizz
            //2) If the number is divisible by 5 print Buzz
            //3) If the number is divisible by both print FizzBuzz
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"Buzz");
                }
            }

            //Write a prgroam that asks the user for a number. The program will print "prime" if the number is prime, otherwise print even or odd as appropriate
            //Prime - divisible only by 1 and itself
            int inputNum;
            bool isPrime = true;
            Console.WriteLine("Enter a number:");
            inputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (inputNum / 2); i++)
            {
                if (inputNum % i == 0 && i != 1 && i != inputNum)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"prime");
            }
            else if (inputNum % 2 == 0)
            {
                Console.WriteLine($"even");
            }
            else
            {
                Console.WriteLine($"odd");
            }
        }
    }
}
