using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Student : Person
    {     
        public string School { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<SchoolSupplies> SchoolSupplies { get; set; }
        public Student(string name) : base(name)
        {           
            
        }

        public void Study()
        {

        }
       
        public void DoHomework()
        {

        }

        public void TakeTest()
        {

        }
    }
}
