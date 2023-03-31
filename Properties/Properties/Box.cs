using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Box
    {
        //Member variables
        private int length = 3;
        private int height;
        public int width;
        private int volume;

        public int Width { get; set; } //Just typ prop and press tab for this to auto-fill for you! (properties)
        public int Volume //For this property, we don't want a SET, because volume is calculated via the get.
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }


        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width; //Don't need to use this, because we're using the Width property
        }


        /*This is the exact same as the get/set above. The one above is more efficient.
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        */

        //We're changing what the height value is here
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value; //if it's a negative value
                }
                else
                {
                    height = value;
                }                //Value is just whatever we set it to in the program.
                                //Value is working simliarly to how length down below is
            }
        }

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0.");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }


        public int FrontSurface
        {
            get
            {
                return height * length;
            }
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2}, so the volume is {3}", length, height, Width, volume = length*height*Width);
        }



    }
}
