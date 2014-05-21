using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 36;
            object boxed = i;

            Console.WriteLine("i = {0}", i);
            Console.WriteLine("boxed = {0}", boxed);

            boxed = (int)boxed + 2;

            Console.WriteLine("i = {0}", i);
            Console.WriteLine("boxed = {0}", boxed);

            i = i + 1;

            Console.WriteLine("i = {0}", i);
            Console.WriteLine("boxed = {0}", boxed);

            i = (int) boxed;

            Console.WriteLine("i = {0}", i);
            Console.WriteLine("boxed = {0}", boxed);

            int? h = null;
            int? j = i;
            object jboxed = j;

            Console.WriteLine("h has a value? {0}", h.HasValue);

            h = jboxed as int?;
            
            Console.WriteLine("h now has the value {0}:", h.Value);

            Console.ReadKey();


        }
    }
}
