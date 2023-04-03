namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a stack
            Stack<int> stack = new Stack<int>();

            if(stack.Count > 0)
            {
                stack.Pop();
            }

            //Adds values to the stack
            stack.Push(1);
            //Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());
            stack.Push(3);
            //Remove an item from the stack
            int myStackItem = stack.Pop();
            Console.WriteLine("The popped value is {0}", myStackItem);
            Console.WriteLine("Top value in the stack is {0}", stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("The top value {0} was removed from the stack.", stack.Pop());
                Console.WriteLine("The current count of values in the stack is {0}", stack.Count);
            }

            if(stack.Count == 0)
            {
                Console.WriteLine("There are no more values in the stack");
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            //Defining a new stack of int
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("The numbers in the array are: ");
            //foreach number in the array
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("The numbers in reverse are: ");
            //as long as the stack isn't empty
            while(myStack.Count > 0)
            {
                int number = myStack.Pop();
                Console.Write(number + " ");
            }

        }
    }
}