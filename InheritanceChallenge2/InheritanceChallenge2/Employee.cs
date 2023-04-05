using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string lastName, string firstName, int salary)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public Employee()
        {
            LastName = "Drury";
            FirstName = "Aaron";
            Salary = 50000;
        }

        public void Work()
        {
            Console.WriteLine("I'm working!");
        }

        public void Pause()
        {
            Console.WriteLine("I'm taking a break");
        }
    }
}
