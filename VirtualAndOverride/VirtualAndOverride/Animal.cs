using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    internal class Animal
    {
        //Name property
        public string Name { get; set; }

        //age property
        public int Age { get; set; }

        //IsHungry boolean to check if animal is hungry
        public bool IsHungry { get; set; }

        //Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true; //Defaults to true (being hungry)
        }

        public virtual void MakeSound()
        {


        }

        //virtual method called Eat that sub-classes can override
        public virtual void Eat()
        {
            //Check if the animal is hungry
            if(IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        //Virtual method play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }

    }
}
