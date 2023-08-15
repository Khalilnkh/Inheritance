using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Student:Person
    {
        public void Learn()
        {
            Console.WriteLine("Learning...");
        }
        public Student(string name,string surname,int age):base(name,surname,age)
        {

        }

    }
}
