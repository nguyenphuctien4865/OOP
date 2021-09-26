using System;

namespace _20110573_Clip057
{
    class Program
    {
        static void Main(string[] args)
        {
            GetName();
        }

        static void GetName()
        {
            string name = string.Empty;
            name = Console.ReadLine();
            SayHi(name);

        }

        static void SayHi (string name)
        {
            Console.WriteLine($"Welcome back, {name}");
        }
    }
}
