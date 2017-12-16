using System;

namespace AreYouSleepy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep have you had?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.Write("Hello " + name + "! ");

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("You are well rested!");
            }
            else
            {
                Console.WriteLine("You need more sleep!");
            }
            Console.ReadLine();
        }
    }
}
