using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithScope
{
    class Contact
    {
        int age;
        void F()
        {
            age = 18;
        }

        void G()
        {
            int age;
            age = 21;
            Console.WriteLine("The value of age is: {0}", age);
        }

        static void Main(string[] args)
        {
            Contact c = new Contact();
            Console.WriteLine(c.age);
            c.F();
            Console.WriteLine(c.age);
            c.G();
            Console.WriteLine(c.age);

            Console.ReadKey();
        }
    }
}
