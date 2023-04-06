namespace CreatingDelegates
{
    internal class Program
    {
        //Defining a delegate
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            //Add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("Between 20 and 30: ", people, filter);

            DisplayPeople("All: ", people, delegate (Person p) { return true; });
        }

        //A method to display the list of people that passes the filter condition
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach(Person p in people)
            {
                //Check if this person passes the filter
                if (filter(p))
                {
                    //Print the persons name and age
                    Console.WriteLine("{0} is {1} years old", p.Name, p.Age);
                }
            }

        }

        //Filters
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }
        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }
        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}