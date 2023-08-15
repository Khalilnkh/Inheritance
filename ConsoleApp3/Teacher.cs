using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("Explaining...");
        }
        public Teacher(string name,string surname,int age):base(name,surname,age)
        {

        }
    }
}
