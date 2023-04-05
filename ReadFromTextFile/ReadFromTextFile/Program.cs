using System.IO;

namespace ReadFromTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1 - reading Text
            /*   string textFile = System.IO.File.ReadAllText(@"H:\Stand-AloneSiteNotes.txt");
               Console.WriteLine("My TextFile contains the following text: {0}", textFile);

               string[] lines = System.IO.File.ReadAllLines(@"H:\Stand-AloneSiteNotes.txt");
               Console.WriteLine("My TextFile has the following while using an array: {0}", textFile);
               foreach(string line in lines)
               {
                   Console.WriteLine("\t" + line);
               }
              */

            // Example 2 - Creates/writing into a new text file
            
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"H:\Stand-AloneSiteNotes.txt", lines);

            /*
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();

            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();

            File.WriteAllText(@"H:\HighScores.txt" + fileName + ".txt", input);
            */

            //Example 3
            using (StreamWriter file = new StreamWriter(@"H:\MyText2.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            //Adds a line of text to your file
            using (StreamWriter file = new StreamWriter(@"H:\MyText2.txt", true))
            {
                file.WriteLine("Additional Line");
            }


        }
    }
}