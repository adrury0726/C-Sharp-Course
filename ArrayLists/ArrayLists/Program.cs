using System.Collections;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring an ArrayList with UNDEFINED amount of object
            ArrayList myArrayList = new ArrayList();

            //Declaing an Arraylist with DEFINED amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(25);

            //This will delete element with specific entry from array. Such as .Remove 13, .Remove "Hello", etc.
            myArrayList.Remove(13);

            //delete element at specific position. 25 in this case.
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList) //Object is the best option when there's multiple data types in an array.
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj; //Need to cast to a double since it's an object converting to a double
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}