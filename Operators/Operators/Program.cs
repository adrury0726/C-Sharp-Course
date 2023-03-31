namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny); //putting ! before the variable makes it do the opposite of what it's assigned. Hence, true actually equals false.

            //Increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num); // ++ is incremental
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", ++num);


            //decrement operator
            num--;
            Console.WriteLine("num is {0}", num); // -- is decremental
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("Result of num1 + num2 = {0}", result);

            result = num1 - num2;
            Console.WriteLine("Result of num1 - num2 = {0}", result);

            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 = {0}", isEqual);


            // conditional operators
            
            // && is the and operator
            // the or operator is ||


            Console.ReadKey();
        }
    }
} 