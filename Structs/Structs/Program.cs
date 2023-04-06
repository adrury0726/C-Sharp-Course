namespace Structs
{
    //Can't use inheritance and can't use default constructors
    public struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        //Specified constructor
        public Game(string name, string developer, double rating, string releasedate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releasedate;
        }

        public void Display()
        {
            Console.WriteLine("Game 1's name is {0}", name);
            Console.WriteLine("Game 1's developer was {0}", developer);
            Console.WriteLine("Game 1's rating is {0}", rating);
            Console.WriteLine("Game 1 was released on {0}", releaseDate);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Aaron";
            game1.rating = 3.5;
            game1.releaseDate = "1/01/2023";

            game1.Display();

            Console.ReadKey();
        }
    }
}