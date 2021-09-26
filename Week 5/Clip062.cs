using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person perOne = new Person();
            perOne.FirstName = "Ahmad";
            perOne.LastName = "Mohey";
            perOne.Country = "Egypt";

            Person perTwo = new Person();
            perTwo.FirstName = "Tim";
            perTwo.LastName = "David";
            perTwo.Country = "Australia";

            Person perThree = new Person();
            perThree.FirstName = "Daniel";

            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(perTwo.FirstName);
            Console.WriteLine(perThree.FirstName);

        }
    }
    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set{ firstName = value; }
        }
        public DateTime BirthDate
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public Person()
        {
            firstName = "Unknown";
        }

    }
}
