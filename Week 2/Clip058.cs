using System;

namespace _20110573_Clip059
{
    class Program
    {
        static void Main(string[] args)
        {
            string FstEmp, SecndEmp;
            FstEmp = "Tien Nguyen";
            SecndEmp = "Nghia Pham";
            Console.WriteLine($"Inside Main\n --- \n {FstEmp} \n {SecndEmp}\n\n");
            ChangeNames(out FstEmp, out SecndEmp);
            Console.WriteLine($"Inside Main\n --- \n {FstEmp} \n {SecndEmp}\n\n");
            Console.ReadLine();

        }
        static void ChangeNames(out string FstEmp,out  string SecndEmp)
        {
            FstEmp = "Trang Le";
            SecndEmp = "Cuong Bui";
            Console.WriteLine($"Inside Main\n --- \n {FstEmp} \n {SecndEmp}\n\n");

        }
    }
}
