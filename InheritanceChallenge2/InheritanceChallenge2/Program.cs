/*Create a main class with the Main method, then a base class with employee with the properties:
 * Name, FirstName, Salary, and the methods Work() and Pause()
 * Create a deriving class boss with the properties CompanyCar and the method Lead()
 * Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHours and a method Learn();
 * Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.
 * Don't forget to create the constructors.
 * Create an object of each of hte three classes (with arbitrary values)
 * and call the methods, Lead() of Boss and Work() of Trainee.
 * Just print out the respective text, what the respective employees do.
 */



namespace InheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee michael = new Employee("Michael", "Miller", 40000);

            michael.Work();
            michael.Pause();
            Console.ReadKey();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 300000);

            chuckNorris.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 10000);

            michelle.Learn();
            michelle.Work();

            Console.Read();

        }
    }
}