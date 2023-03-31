namespace JaggedArrayChallenge
{
    internal class Program
    {
        // Create a jagged array, which contains 3 "Friends Arrays", in which two family members should be stored
        //Introduce family members from different families to each other via the console (three introductions)
        static void Main(string[] args)
        {
            string[][] friendsAndFamily = new string[][]
            {
                new string[] {"Michael", "John"},
                new string[] {"Frank", "Jessica"},
                new string[] {"Andrew", "Mary"}
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you!", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you!", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you!", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.ReadKey();
        }
    }
}