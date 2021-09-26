using System;

namespace _20110573_Clip011
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string x = string.Format("Date is {0:yyyy MMMM dddd}", myDate);
            Console.WriteLine(x);

        }
    }
}
