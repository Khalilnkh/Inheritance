using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Teacher tc = new Teacher("Ali","Khalil",25);
            Student st = new Student("Kheyrulla","Kahlil",26);
            tc.Explain();
            st.Learn();

        }
    }
}
