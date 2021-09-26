using System;
using System.Windows.Forms;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Bob", "Jones", 2, 2, 1989, 3, 12, 2016);

            MessageBox.Show(e.ToEmployeeString(), "Testing Class Employee");
        }
    }
}
