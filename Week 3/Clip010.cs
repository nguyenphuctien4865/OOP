using System;

namespace _20110573_Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("Number x is " + x);
            x = 5;
            Console.WriteLine("Number x is " + x);

            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.250m;

            Console.WriteLine("Double is " + double_num + " float is " + float_num + "decimal is " + decimal_num);
            string firstName, LastName, House;
            firstName = "Jon";
            LastName = "Snow";
            House = "Stark";

            Console.Write("Hello, " + firstName + LastName+"of Hous Stark");

            bool IsWorking;
            IsWorking = true;
            Console.WriteLine(IsWorking);

            int sum;
            sum = 0;
            int number1, number2;

            number1 = 5;
            number2 = 100;
            sum = number2;
            Console.WriteLine(sum);
        }
    }
}
