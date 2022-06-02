using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Teacher : Person
    {   
        public Teacher(string name) :base(name)
        {
  
        }
        List<Subject> SubjectsToTeach { get; set; }
        public void Teach()
        {

        }
    }
}
