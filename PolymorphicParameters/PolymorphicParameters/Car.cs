using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicParameters
{
    internal class Car
    {
        public int HP { get; set; } //HorsePower
        public string Color { get; set; }

        //Has-a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCardIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: " + HP + " color:" + Color);
        }

        //Virtual allows other classes to override
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired.");
        }

    }
}
