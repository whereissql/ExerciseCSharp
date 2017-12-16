using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExercises
{
    enum statusCode { Ok, Error };
    class Program
    {
        static void Main(string[] args)
        {
            //When you post a meesage on Facebook, depending on the number of people who like your post, facebook displays different information
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            //Depending on the number of names provided, display a message based on the above pattern.
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name:");
                var nameInput = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nameInput))
                {
                    names.Add(nameInput);
                }
                else
                {
                    break;
                }
            }

            var displayLikes = "";

            switch(names.Count)
            {
                case 0:
                    break;
                case 1:
                    displayLikes = names[0] + " likes your post";
                    break;
                case 2:
                    displayLikes = names[0] + ", " + names[1] + " like your post"; 
                    break;
                default:
                    displayLikes = names[0] + ", " + names[1] + " and " + (names.Count - 2) + " others like your post";
                    break;
            }

            Console.WriteLine(displayLikes);
            Console.ReadLine();

            //Write a program and ask the user to enter their name.
            //Use an array to reverse the name and then store the result in a new string.
            //Display the reversed name on the console.
            Console.WriteLine("Enter your name:");
            char[] nameOfUser = Console.ReadLine().ToCharArray();
            Array.Reverse(nameOfUser);
            Console.WriteLine(new string(nameOfUser));
            Console.ReadLine();

            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            int count = 0;
            const int MaxNumbers = 5;
            int[] numbers = new int[MaxNumbers];
            Console.WriteLine("Enter 5 numbers:");
            
            while (count < MaxNumbers)
            {
                var errorStatus = statusCode.Ok;
                int newInput = Convert.ToInt32(Console.ReadLine());
                foreach(int number in numbers)
                {
                    if (number == newInput)
                    {
                        Console.WriteLine("Error: This number has been entered previously! Please try a different number.");
                        errorStatus = statusCode.Error;
                        break;
                    }
                }
                if(errorStatus == statusCode.Ok)
                {
                    numbers[count] = newInput;
                    count++;
                }                
            }

            Array.Sort(numbers);
            for(int i = 0; i < MaxNumbers; i++)
            {
                Console.WriteLine($"Elelement at posistion {i} after sorting is {numbers[i]}");
            }
            Console.ReadLine();
            //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //The list of numbers may include duplicates.Display the unique numbers that the user has entered.


            //Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //otherwise, display the 3 smallest numbers in the list.
        }
    }
}
