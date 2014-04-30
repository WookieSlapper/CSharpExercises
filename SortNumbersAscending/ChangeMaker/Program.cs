using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a program that accepts a decimal and returns change in quarters, then dimes, then nickels, etc.
            decimal quarter = (decimal) 0.25;
            decimal dime = (decimal) 0.10;
            decimal nickel = (decimal) 0.05;
            decimal penny = (decimal) 0.01;

            //input amount from user
            Console.WriteLine("Please enter an amount of currency you would like converted to change: $");
            decimal convertToChange = decimal.Parse(Console.ReadLine());
            //divide amount into quarters, with remainder
            int quarters = (int)(convertToChange / quarter);
            //subtract dime amounts
            int dimes = (int)((convertToChange % quarter) / dime);
            //subtract nickel amounts
            int nickels = (int)(((convertToChange % quarter) % dime) / nickel);
            //balance in pennies
            int pennies = (int)((((convertToChange % quarter) % dime) % nickel) / penny);
            //print result
            Console.WriteLine("Your change will include {0} quarters, {1} dimes, {2} nickels, and {3} pennies.", quarters, dimes, nickels, pennies);
        }
    }
}
