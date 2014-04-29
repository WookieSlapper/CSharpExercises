using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbersAscending
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;
            while (shouldContinue)
            {
                string unsortedText = null;

                while (unsortedText == null)
                {
                    Console.WriteLine("Enter a comma-separated array of numbers: ");
                    unsortedText = Console.ReadLine();
                }

                var unsortedNumbers = unsortedText.Split(',').Select(i => Convert.ToInt32(i)).ToArray();
                int[] sorted = SortAscending(unsortedNumbers);

                Console.WriteLine("Here is your result: ");
                Console.WriteLine(String.Join(",", sorted));
                Console.WriteLine("Enter \"1\" if you would like to continue: ");
                shouldContinue = Console.ReadKey().KeyChar.Equals('1');
            }
        }

        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                {
                    minPos = pos;
                }
            return minPos;
        }

        public static void IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                {
                    Exchange(data, i, k);
                }
            }
        }

        private static void Exchange(int[] ToExchange, int index1, int index2)
        {
            int temp;
            temp = ToExchange[index2];
            ToExchange[index2] = ToExchange[index1];
            ToExchange[index1] = temp;
        }

    }
}


