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
        }
    }
}
