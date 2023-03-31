using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    //This class ia blueprint for a datatype
    internal class Human
    {
        //member variable. Must add public to the variable name in order to use outside of this class
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //Default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
         //this.firstname is using the global variable, whereas the firstName on the right is using the name within the constructor paramaters
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //Constructors for when age is missing.
        public Human(string firstName, string lastName, string eyeColor)
        {
            //Since we have age set as a global variable, it will default to 0 if we don't assign it here.
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age)
        {
            //this.firstname is using the global variable, whereas the firstName on the right is using the name within the constructor paramaters
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //Constructors for when age and eyeColor is missing.
        public Human(string firstName, string lastName)
        {
            //Since we have age set as a global variable, it will default to 0 if we don't assign it here.
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Constructors for when all but firstName is missing.
        public Human(string firstName)
        {
            //Since we have age set as a global variable, it will default to 0 if we don't assign it here.
            this.firstName = firstName;
        }


        // Member method
        public void IntroduceMyself()
        {
            if(age != 0 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi I'm {0} {1}, the color of my eyes are {2}, and I'm {3} years old", firstName, lastName, eyeColor, age);
            
            else if (age != 0 && lastName != null && firstName != null && eyeColor == null)
            {
                Console.WriteLine("Hi I'm {0} {1} and I'm {2} years old", firstName, lastName, age);
            }

            else if (lastName != null && firstName != null && age == 0 && eyeColor == null)
            {
                Console.WriteLine("Hi I'm {0} {1}", firstName, lastName);
            }

            else if (lastName != null && lastName == null && eyeColor == null && age == 0)
            {
                Console.WriteLine("Hi I'm {0}", firstName);
            }

            else
                    {
                Console.WriteLine("Hi I'm {0} {1} and the color of my eyes are {2}", firstName, lastName, eyeColor);
            }
        }
    }
}
