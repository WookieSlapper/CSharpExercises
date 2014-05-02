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



            //Modify the previous program such that only multiples of three or five are considered in
            // the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for 'n = 17'
            Console.WriteLine("Please enter a number:");
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int i2 = 0;

            while (i2 <= n)
            {
                int x = i2 % 3;
                int y = i2 % 5;

                if (x == 0 || y == 0)
                {
                    sum1 += i2;
                }

                i2++;
            }

            Console.WriteLine("The sum of all numbers from 1 to {0} that are evenly divisible by 3 or 5 is: {1}", n, sum1);



            //Write a program that asks the user for a number 'n' and gives him the possibility to choose between computing
            // the sum and computing the product of 1...n.
            Console.WriteLine("Please enter a number: ");
            int yourNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The number you entered was {0}. Enter '1' to find the sum of all numbers to {0}, or enter '2' to find the product of all numbers from 1 to {0}.", yourNumber);
            int operationChoice = int.Parse(Console.ReadLine());

            while (operationChoice != 1 && operationChoice != 2)
            {
                Console.WriteLine("You have entered an invalid choice. \nPlease enter '1' for sum, or '2' for product: ");
                operationChoice = int.Parse(Console.ReadLine());
            }

            if (operationChoice == 1)
            {
                Console.WriteLine("The sum of all numbers from 1 to {0} is: {1}", yourNumber, numberSum(yourNumber));
            }
            else if (operationChoice == 2)
            {
                numberProduct(yourNumber);
                Console.WriteLine("The product of all numbers from 1 to {0} is: {1}", yourNumber, numberProduct(yourNumber));
            }
        }

        public static int numberSum(int numberEntered)
        {
            int yourSum = 0;
            int i = 0;
            while (i <= numberEntered)
            {
                yourSum += i;
                i++;
            }
            return yourSum;
        }

        public static int numberProduct(int numberEntered)
        {
            int yourSum = 1;
            int i = 1;
            while (i <= numberEntered)
            {
                yourSum *= i;
                i++;
            }
            return yourSum;
        }
    }
}
