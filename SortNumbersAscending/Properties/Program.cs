using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact();
            Console.WriteLine(c.ToString());

            c.firstName = "Jim";
            c.lastName = "Morrison";
            c.DateOfBirth = new DateTime(1943, 12, 8);
            Console.WriteLine(c.ToString());

            Contact d = new Contact();
            d.firstName = "Dominic";
            d.lastName = "Mazella";
            d.DateOfBirth = new DateTime(1972, 07, 07);
            Console.WriteLine(d.ToString());

            c.Search(37.479444f, -122.450278f);
            c.Search(37.479444f, -122.450278f, 50);
            c.Search(37.479444f, -122.450278f,culture: "en");
            Console.WriteLine(c.VerifyEmailAddress("joe@example.com"));
            Console.WriteLine(c.VerifyEmailAddress("jim@example.com"));

            Contact alex = new Contact("Alex", "Mazella")
            {
                DateOfBirth = new DateTime(1943, 10, 19),
            };
            Console.WriteLine(alex.ToString());

            Console.ReadKey();
        }
    }
}
