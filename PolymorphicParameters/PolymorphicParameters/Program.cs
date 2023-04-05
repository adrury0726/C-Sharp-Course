namespace PolymorphicParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "Blue", "A4"),
                new BMW(250, "Red", "M3")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            //Here is pulling from Car class's ShowDetails
            Car bmwZ3 = new BMW(200, "Black", "Z3");
            Car audiA3 = new Audi(100, "Green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Aaron Drury");
            audiA3.SetCarIDInfo(54321, "Johnny Bravo");
            bmwZ3.GetCardIDInfo();
            audiA3.GetCardIDInfo();

            //Pulls from BMW class
            BMW bmwM5 = new BMW(330, "White", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "Red", "M3");
            myM3.Repair();

            Console.ReadKey();
        }
    }
}