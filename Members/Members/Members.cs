using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    internal class Members
    {
        //Member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //Member - public field
        public int age;

        //Member - Property - exposes jobTitle safely. Properties always start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //Public member Method - Can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old.", memberName, JobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            JobTitle = "Developer";
            Console.WriteLine("Object created.");
        }

        //Member- Finalizer - Destructor
        //Only use finalizer if you need it. It does affect performance, so only use when necessary.
        ~Members()
        {
            //Cleanup statements
            Console.WriteLine("Deconstruction of Members object.");
            Debug.Write("Destruction of Members object");
        }

    }
}
