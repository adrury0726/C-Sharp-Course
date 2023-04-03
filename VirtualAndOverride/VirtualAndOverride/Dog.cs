using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    class Dog : Animal
    {
        //bool property to check if the dog is happy
        public bool IsHappy { get; set; }

        //Constructor where we pass name and age to our base constructor
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            //Calling the eat method from Animal class (base class), but overriding it
            base.Eat();
        }

        //Since all animals make different sounds, we need to override for each different animal
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public override void Play()
        {
            if(IsHappy)
            {
                base.Play();
            }
        }

    }
}
