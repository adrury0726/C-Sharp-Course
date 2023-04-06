namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of names
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli"};

            Console.WriteLine("-----before-----");
            //print the names before the remove all method
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            //Calling RemoveAll and passing the method Filter
            names.RemoveAll(Filter);

            Console.WriteLine("-----After-----");
            //print the names after the remove all method
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }

        static bool Filter(string s)
        {
            //Return true if the string contains an "i"
            return s.Contains("i");
        }


    }
}