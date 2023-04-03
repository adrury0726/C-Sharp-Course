using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ElectricalDevice
    {
        //Boolean to determine state of the radio
        public bool IsOn { get; set; }

        //string for the brand name of the video
        public string Brand { get; set; }

        public ElectricalDevice(bool isON,  string brand)
        {
            IsOn = isON;
            Brand = brand;
        }

        //switch on the Electrical Device
        public void SwitchOn()
        {
            IsOn = true;
        }

        //switch off the Electrical Device
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}
