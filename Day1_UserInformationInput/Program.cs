using System;

namespace Day1_UserInformationInput
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, address, phoneNumber, age;
            DateTime birthdate;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your address:");
            address = Console.ReadLine();
            Console.WriteLine("Please enter your phone number:");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            age = Console.ReadLine();
            Console.WriteLine("Please enter your birthdate MM/DD/YYYY:");
            birthdate = DateTime.Parse(Console.ReadLine());
            

            Console.WriteLine($"Hello {name}, you live at {address}, your phone number is {phoneNumber} and you are {age} years old born in {birthdate.Year}");
        }
    }
}
