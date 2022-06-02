using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Walk()
        {

        }
        public void See()
        {

        }
        public void Talk()
        {
            Console.WriteLine($"Hi, im {Name}, blabla");
        }
    }
}
