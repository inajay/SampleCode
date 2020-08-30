using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public class Person : Student
    {
        public Person(string name): base(name)
        {

        }
    }

   public class Student
    {
        public Student(string name)
        {
            
        }

        public int RollNo { get; set; }

        public String  NameOfStudent { get; set; }

        public string GetAddress(string name)
        {
            return name + "City Name";
        }
    }
}
