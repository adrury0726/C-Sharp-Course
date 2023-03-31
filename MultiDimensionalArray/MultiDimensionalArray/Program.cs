namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 2D Array
            string[,] matrix;

            //Endlessly ramps up depending on # of commas
            //3D Array
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 }, //row 0
                { 4, 5, 6 }, //row 1
                { 7, 8, 9 } //row 2
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]); //returns 5
            Console.WriteLine("Central value is {0}", array2D[2, 0]); //returns 7
            Console.ReadKey();

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "What's up"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "Last entry"}
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                    {"One", "Two"},
                    {"Three", "Four"},
                    {"Five", "Six"}
            };

            array2DString[1, 1] = "Chicken"; //Chaning the value "Four" to Chicken in the array2DString

            int dimensions = array2DString.Rank; //Rank tells you how many dimensions in the array

            Console.WriteLine("The number of dimensions is {0}", dimensions);
            Console.WriteLine("The array is {0}", array2DString[1,1]);
            Console.WriteLine("The value is {0}", array3D[1, 1, 0]); //returns 110, need 3 values since this is a 3 dimensional array
            Console.WriteLine("The value is {0}", array3D[0, 2, 0]); //returns "Hi there"
            Console.ReadKey();
        }
    }
}