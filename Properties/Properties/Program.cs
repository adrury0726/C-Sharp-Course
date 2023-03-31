namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create instance of the class Box
            //Box box = new Box();
            //box.length = 3;
            // box.SetLength(4);
            // box.Height = -4; //Accessing the property Height
            // box.Width = 5;

            Box box = new Box(3, 4, 5);

            Console.WriteLine("Box's Width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box's Width is " + box.Width);
            Console.WriteLine("Box's volume is " + box.Volume);

            Console.WriteLine("Front surface of the box is {0}", box.FrontSurface);


            box.DisplayInfo();
        }
    }
}