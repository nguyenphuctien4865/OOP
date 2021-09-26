using System;

namespace _20110573_Clip60
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, intResult;
            double x, y, z, douRedsult;

            intResult = 0;
            a = 1;
            b = 2;
            c = 3;

            douRedsult = 0;
            x = 0.5;
            y = 1.50;
            z = 2.0;

            Console.WriteLine(PerformAdd(x, y, z));

        }

        static int PerformAdd(int num1, int num2)
        {
            return num1 + num2;
        }

        static int PerformAdd(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;
        }
      
        static double PerformAdd(double num1, double num2)
        {
            return num1 + num2;
        }
        static double PerformAdd(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
    }
}
