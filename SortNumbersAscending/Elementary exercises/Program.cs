using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints 'Hello World' to the screen
            Console.WriteLine("Hello World!");

            //Write a program that asks the user for his name and greets him with his name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);

            //Modify the previous program such that only the users Alice and Bob are greeted
            //with their names
            Console.WriteLine("What is your name?");
            string name2 = Console.ReadLine();
            if (name2 == "Bob" || name2 == "Alice")
                Console.WriteLine("Hello, {0}!", name2);
            else
                Console.WriteLine("I don't know you!");

            //Write a program that asks the user for a number 'n' and prints the sum of the
            //numbers 1 to 'n'
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, i = 0;
            while (i <= number)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("The sum of all the numbers between one and {0} is: {1}", number, sum);

            //The above loop can also be written as a function that accepts an int 'n' parameter with 
            //the following body:
            //long sum = n * (n + 1)/2;
            //This formula was discovered by the famous mathematician Gauss to quickly find the sum
            // of all numbers from 1 up to a given number
        }
    }
}
