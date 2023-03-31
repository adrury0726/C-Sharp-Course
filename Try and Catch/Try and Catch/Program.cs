namespace Try_and_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Can't divide by zero!");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format Exception. Please enter a number next time.");
            }
            //catch (Exception) this type will work for any/all types of exceptions
            catch(OverflowException)
            {
                Console.WriteLine("General exception");
            }
            finally //This line will run regardless of if the try is successful or not. Good practice to always have in try/catch blocks
            {
                Console.WriteLine("This is called no matter the result.");
            }


          //  int userInputAsInt = int.Parse(userInput);

            Console.ReadKey();

        }
    }
}