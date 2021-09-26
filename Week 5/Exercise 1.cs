using System;

namespace _20110573_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ? ");
            var name = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0} My name is C#, How old ar you ?", name);
            bool isSuccess = int.TryParse(Console.ReadLine(), out int age);
            if (isSuccess == true)
            {
                Console.WriteLine("{0} good, As for me I was born on 2002. Which makes me {1} years old", age, DateTime.Now.Year - 2002);
            }
            else
            {
                Console.WriteLine("That is not a correct input");
            }
        }
    }
}
