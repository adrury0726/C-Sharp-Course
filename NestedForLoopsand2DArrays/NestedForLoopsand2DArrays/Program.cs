namespace NestedForLoopsand2DArrays
{
    internal class Program
    {
        static int[,] matrix =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        static void Main(string[] args)
        {
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i, j]);
            }
 
        }

    }
}

/*            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i,i]);
            }
*/
/*
        static void Main(string[] args)
        {
            foreach(int item in matrix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nThis is our 2D array printed using nested for loop");
            //Nested For Loop
            //outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //if (matrix[i,j] % 2 == 0) //Checks if the value is an even number. Can do == 1 for odds
                    if (i == j)
                        matrix[i, j] = 1;
                    //Console.Write(matrix[i, j] + " "); //display i row and j column of the array
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }

            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

        }
*/
