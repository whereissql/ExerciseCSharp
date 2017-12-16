using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Divisible By 3
            int count = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i%3 == 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine($"Count of numbers divisible by 3 (between 1 and 100): {count}");

            //As user to enter number and ok to exit. Display sum of numbers
            int sumOfInput = 0;
            while(true)
            {
                Console.WriteLine("Enter a number or \"OK\" to exit");
                var input = Console.ReadLine();
                if (input.ToUpper().Equals("OK"))
                {
                    break;
                }
                else
                {
                    sumOfInput += Convert.ToInt32(input);
                }
            }
            Console.WriteLine($"Sum of all inputs is {sumOfInput}");

            //GetFactorial
            Console.WriteLine("Enter number to get factorial:");
            var numberFactorial = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            for(int i = numberFactorial; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {numberFactorial} is {factorial}");

            //Pick random number between 1 and 10. Give user 4 chances to guess the number
            const int MaxNumber = 10;
            const int MaxAttempt = 4;
            var random = new Random();
            var secretNumber = random.Next(MaxNumber);

            for(int i= 0; i < MaxAttempt; i++)
            {
                Console.WriteLine("Guess the secret number:");
                if(Convert.ToInt32(Console.ReadLine()) == secretNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost!");
                }
            }
            Console.WriteLine($"Secret number was {secretNumber}!");
            Console.ReadLine();

            //Get input of numbers separated by comma. display maximum of the numbers
            Console.WriteLine("Enter numbers separated by comma: example 1,4,6,7: ");
            var userInput = Console.ReadLine();
            var largestNumber = 0; 
            string[] numbers = userInput.Split(',');
            foreach(string character in numbers)
            {
                if(Convert.ToInt32(character) > largestNumber)
                {
                    largestNumber = Convert.ToInt32(character);
                }
            }
            Console.WriteLine($"Largest integer in input string is {largestNumber}");
            Console.ReadLine();
        }
    }
}
