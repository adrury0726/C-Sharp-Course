namespace ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, 0, -11, 5); //Passing 7 values here

            Console.WriteLine("The minimum is {0}", min);
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min) //We're searching the list to find the smallest value
                    min = number;
            }
            return min;
        }


    }
}

/*     //Params keyword really just lets you pass as many paramters are you want
     public static void ParamsMethod(params string[] sentence)
     {
         for (int i = 0; i < sentence.Length; i++)
         {
             Console.Write(sentence[i] + " ");
         }
     }

     public static void ParamsMethod2(params object[] stuff)
     {
         foreach (object obj in stuff)
         {
             Console.Write(obj + " ");
         }
         Console.WriteLine();
     }*/
