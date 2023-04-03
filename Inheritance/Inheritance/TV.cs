using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class TV : ElectricalDevice //TV is the child class. So it's inheriting from ElectricalDevice class
    {
        //Simple constructor
        public TV(bool isOn, string brand): base(isOn, brand)
        {
 
        }

        public void WatchTV()
        {
            //Check if TV is on
            if(IsOn)
            {
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //Error msg if TV is off
                Console.WriteLine("TV is not on. Please turn it on first!");
            }
        }
    }
}
