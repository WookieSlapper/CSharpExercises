using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class GradeBook
    {
        public GradeBook()  //initialization tasks for an object performed inside the constructor
        {
            
        }   //ctor is a code snippet for constructor, where compiler will create a constructor for the current class

        public void AddGrade(float grade)  //constructor for the class
        {
            grades.Add(grade); //this tast will be completed each time .AddGrade is used -- a grade will be added to the List
        }

        List<float> grades = new List<float>(); //field for collection of data; List constructor defined in Collections class
    }
}
