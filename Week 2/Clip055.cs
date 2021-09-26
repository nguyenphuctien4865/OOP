using System;

namespace _20110573_Clip055
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;
            a = 5;
            b = 3;
            addResult = PerformADdOperation(a, b);
            Console.WriteLine($"{a}+{b}= {addResult}");
            DisplayMessage();

            c = 15;
            d = 10;
            addResult = PerformADdOperation(int x, int y)
            Console.WriteLine($"{c}+{d}= {addResult}");
            DisplayMessage();


        }
        static int PerformADdOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            return addResult;
        }
        static void DisplayMessage()
        {
            Console.WriteLine("Process is done");
            Console.WriteLine("This process is run by Tien");
            Console.WriteLine("Finish on Time : "+DateTime.Now.ToShortTimeString());

        }
    }
}
