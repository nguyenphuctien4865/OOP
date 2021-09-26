using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHi();
            SayHi();
        }
        static void SayHi()
        {
            Console.WriteLine("Hi!, from the static method");
        }
    }
    class Person
    {
        public void SayHi()
        {
            Console.WriteLine("Hi!, from the non static method");
        }
    }
}
