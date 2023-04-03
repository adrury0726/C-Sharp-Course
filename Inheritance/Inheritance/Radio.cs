using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Radio : ElectricalDevice //Radio is the child class. So it's inheriting from ElectricalDevice class
    {
        public Radio(bool isOn, string brand): base(isOn, brand) //pulling from ElectricalDevice
        {

        }

        //method to listen to the radio
        public void ListenRadio()
        {
            //Checking if radio is on
            if(IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                //Prints error message
                Console.WriteLine("Radio switch is off. Turn it on first!");
            }
        }
    }
}
