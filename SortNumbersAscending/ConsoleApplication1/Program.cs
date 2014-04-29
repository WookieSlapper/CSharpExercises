using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt for string
            Console.WriteLine("Please enter a word or phrase");

            //accept string
            string InputLine = Console.ReadLine();
            string trimmed = InputLine
                                .Replace(" ", "")
                                .Replace(",", "")
                                .ToLower();

            //parse into individual elements
            char[] Letters = trimmed.ToCharArray();

            //swap elements front to back
            int N = Letters.Length;
            string reversed = "";
            for(int i = 0; i < N; i++){
                reversed = Letters[i] + reversed;
            }
            //detect palindrome
            var isPalindrome = trimmed.Equals(reversed);

            if (isPalindrome)
                Console.WriteLine("The word or phrase is a palindrome");
            else
                Console.WriteLine("Not a palindrome");

            Console.ReadKey();
        }
    }
}
