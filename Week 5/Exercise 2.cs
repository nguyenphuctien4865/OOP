using System;

namespace _20110573_Clip032_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day...");
            var day = Console.ReadLine();

            Console.WriteLine("Enter the month...");
            var month = Console.ReadLine();

            Console.WriteLine("Enter the year...");
            var year = Console.ReadLine();

            DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            Console.WriteLine("\n" + date.DayOfWeek);
        }
    }
}
