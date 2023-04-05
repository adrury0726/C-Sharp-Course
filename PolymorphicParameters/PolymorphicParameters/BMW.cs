using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicParameters
{
    internal class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }
        
        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }


        //"New" means this one has priority over the ShowDetails in the Car class
         public new void ShowDetails()
        {
            Console.WriteLine("Brand " + brand + "HP: " + HP + " color:" + Color);
        }

        //Can only used seal before override or the Class keyword
        //Sealed keyword does makes it so that this cannot be inherited
        /*public  sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired.", Model);
        }
        */

        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired.", Model);
        }
    }
}
