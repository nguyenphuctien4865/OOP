using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    public class Employee
    {
        private int birthDate;
        private int firstName;
        private Date hireDate;
        private Date lastName;

        public Employee(string first, string last , int birthMonth, int birthDay,int birthYear,int hireMonth,int hireDay, int hireYear)
        {
            firstName = first;
            lastName = last;

            birthDate = new Date(birthMonth, birthDay, birthYear);
            hireDate = new Date(birthMonth, birthDay, birthYear);

        }


        public string ToEmployeeString()
        {

            return lastName + ", " + firstName + " Hired: " + hireDate.ToDateString() + " Birthday: " + birthDate.ToDateString();
        }
    }
}