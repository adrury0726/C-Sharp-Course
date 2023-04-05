namespace IEnumerableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create IEnumerable variable that takes int collection type
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            //New Line
            Console.WriteLine(" ");

            //Call GetCollection() with option = 2 which will return a Queue<int>
            unknownCollection = GetCollection(2);

            Console.WriteLine("This was a Queue<int>");
            //for each number in the collection we got back from GetCollection(2)
            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            //This will return our else collection
            unknownCollection = GetCollection(5);

            Console.WriteLine("This was a Queue<int>");
            //for each number in the collection we got back from GetCollection(5)
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

        }

        static IEnumerable<int> GetCollection(int option)
        {
            //Create a list of numbers and initialize it
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            //add values to the queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            //if option is 1
            if (option == 1)
            {
                //return the list of type List<int>
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}