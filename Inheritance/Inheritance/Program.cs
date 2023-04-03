namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            //myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            //method of base class
            myTV.SwitchOn();
            //method of child class
            myTV.WatchTV();
        }
    }
}