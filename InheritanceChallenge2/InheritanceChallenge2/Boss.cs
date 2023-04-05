using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Boss:Employee
    {
        public string CompanyCar { get; set; }
        
        public Boss(string companyCar, string lastName, string firstName, int salary): base(lastName, firstName, salary) //base is the same as using this.name, it just saves us work
        {
            this.CompanyCar = companyCar;   
        }

        public void Lead()
        {
            Console.WriteLine("I'm the boss, and my name is {0} {1}", FirstName, LastName);
        }
    }
}
