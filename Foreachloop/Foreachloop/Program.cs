namespace Foreachloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for(int j = 0; j < nums.Length; j++) //length keeps it from going out of range if there's more than 10 values. Lets you do more than 10.
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            //This foreach loop does the same thing as the code above.
            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k); counter++;
            }

            Console.ReadKey();


            string[] friends = {"John", "Michael", "Jessica", "James", "Dylan"};

            foreach(string name in friends)
            {
                Console.WriteLine("Hello {0}, my friend!", name);
            }

            Console.ReadKey();
        }
    }
}