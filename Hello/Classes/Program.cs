using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook class1 = new GradeBook();  //implicit constructor
            class1.AddGrade(81);
            class1.AddGrade(89.5f);
        }
    }

}
