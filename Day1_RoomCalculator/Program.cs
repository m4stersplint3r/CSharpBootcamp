using System;

namespace Day1_RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height, volume, area, perimeter;
            bool continueInput = true;
            Console.WriteLine("Welcome to my room size generator" + Environment.NewLine);
            
            while(continueInput)
            {
                Console.Write("Enter Length of room: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width of room: ");
                width = double.Parse(Console.ReadLine());
                Console.Write("Enter Height of room: ");
                height = double.Parse(Console.ReadLine());
                
                area = length * width;
                perimeter = (length * 2) + (width * 2);
                volume = area * height;
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Volume: {volume}" + Environment.NewLine);
                Console.Write("Continue? (y/n):");
                if (!Console.ReadLine().ToLower().Equals("y"))
                {
                    continueInput = false;
                }
            }
            
        }
    }
}
