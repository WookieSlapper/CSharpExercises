using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            MultTable(12);
        }
        public static void MultTable(int n)
        {
            // Write a program that prints a multiplication table for numbers up to 12
            int numberWidth = ("" + n).Length;
            string colFormat = string.Format("{{0,{1}}} ", numberWidth, (n / 2));
            string headerFormat = colFormat + "| ";

            Console.Write(headerFormat, "*");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(colFormat, i);
            }
            Console.WriteLine();

            Console.WriteLine(StringOfReps("- ", (numberWidth + 1) * (n + 1) + 1));

            for (int r = 1; r <= n; r++)
            {
                Console.Write(headerFormat, r);
                for (int c = 1; c <= n; c++)
                {
                    Console.Write(colFormat, (r * c));
                }
                Console.WriteLine();
            }
        }

        static string StringOfReps(string s, int n)
        {                                                     // body
            for (int i = 0; i < n; i++)
            {
                Console.Write(s + " ");
            }
            return s;
        }
    }
}
