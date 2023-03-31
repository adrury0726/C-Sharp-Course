namespace MyFirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using constructor here
            Human johnny = new Human("Johnny", "Bravo", "Blue", 34);
            johnny.IntroduceMyself();

            Human jake = new Human("Jake", "Holton", "Green", 27);
            jake.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Jordan");
            michael.IntroduceMyself();

            Human frank = new Human("Frank", "Gallagher", 25);
            frank.IntroduceMyself();

            Console.ReadKey();



            //No constructor used
            
            /*         Human johnny = new Human();
                     johnny.firstName = "Johnny";
                     johnny.lastName = "Bravo";
                     johnny.IntroduceMyself();


                     Human john = new Human();
                     john.firstName = "John";
                     john.lastName = "Cena";
                     john.IntroduceMyself();

                     Console.ReadKey();
            */

            //Creating an object of my class
            // an instance of Human
            /*   Human aaron = new Human();

                   //Access public variable from Human.cs, and can even change it
                    aaron.firstName = "Aaron";

                    //Calling methods of the class from Human.cs
                    aaron.IntroduceMyself();

                    Human michael = new Human();
                    michael.firstName = "Mikel";
                    michael.IntroduceMyself();


                    Console.ReadKey();
              */
        }
    }
}