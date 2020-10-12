using System;

namespace Day1_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old. In 10 years you will be " + (age + 10));
        }
    }
}
