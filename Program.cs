using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        //Pause til kl 13.00! 
        static void Main(string[] args)
        {
            var person1 = new Person("Carina");
            var person2 = new Person("Christian Arella");
            var person3 = new Person("Renèe");

            var student1 = new Student("Tommy");
            var student2 = new Student("Magnus");
            var student3 = new Student("Kristian R.");

            var teacher = new Teacher("Silje");
            var teacher2 = new Teacher("Joakim");
            var teacher3 = new Teacher("Marie");

            var people = new MariesSpesialListeForOCD<Person>();
            people.AddThree(person1, person2, person3);
            people.AddThree(student1, student2, student3);
            people.AddThree(teacher, teacher2, teacher3);

            foreach(var person in people)
            {
                person.Talk();
            }

            //person1.Talk();
            //person2.Talk();
            //person3.Talk();

            //student1.Talk();
            //student2.Talk();
            //student3.Talk();

            //teacher.Talk();
            //teacher2.Talk();
            //teacher3.Talk();
        }
    }
}
