using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Trainee:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, string lastName, string firstName, int salary):base(lastName, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!", SchoolHours);
        }

        public void Work()
        {
            Console.WriteLine("I work for {0} hours", WorkingHours);
        }

    }
}
