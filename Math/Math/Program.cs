using System;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + MathF.Ceiling(15.3f)); //Rounds up number
            Console.WriteLine("Floor: " + MathF.Floor(15.3f)); //Rounds down

            int num1 = 13;
            int num2 = 9;
            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, MathF.Min(num1, num2));
            Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, MathF.Max(num1, num2));

            Console.WriteLine("3 to the power of 5 is {0}", MathF.Pow(3, 5)); // 3^5
            Console.WriteLine("PI is {0}", MathF.PI);

            Console.WriteLine("The square root of 25 is {0}", MathF.Sqrt(25));
            Console.WriteLine("Always positive is {0}", MathF.Abs(-25));

            Console.WriteLine("cos of 1 is {0}", MathF.Cos(1));

            Console.ReadLine();
        }
    }
}