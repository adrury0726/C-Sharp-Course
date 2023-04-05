namespace IEnumerableExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of type List<int> initialized
            List<int> numberList = new List<int>() { 8, 6, 2};
            //Array of type int[] initialized
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            //new line
            Console.WriteLine(" ");
            //Call CollectionSum() and pass the list to do it
            CollectionSum(numberList);

            Console.WriteLine(" ");
            //Call CollectionSum() and pass the list to do it
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                //add the num value to the sum
                sum += num;
            }

            Console.Write("Sum is {0}", sum);
        }
    }
}