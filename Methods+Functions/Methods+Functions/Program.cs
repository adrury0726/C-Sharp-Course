namespace Methods_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int result = Add(15, 31);
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(12, 3));
            Console.WriteLine(Divide(12, 4));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num3, int num4)
        {
            return num3 * num4;
        }

        public static double Divide(int num3, int num4)
        {
            return num3 / num4;
        }

    }
}