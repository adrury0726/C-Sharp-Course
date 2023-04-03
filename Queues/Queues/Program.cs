namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order o in ReceiveOrdersFromBranch1())
            {
                //Add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                //Add each order to the queue
                ordersQueue.Enqueue(o);
            }

            //As long as the queue is not empty
            while(ordersQueue.Count > 0)
            {
                //Remove the order at the front of the queue and store it in the currentOrder variable
                Order currentOrder = ordersQueue.Dequeue();
                //Process the order
                currentOrder.ProcessOrder();
            }

        }


        /*
        //Queues are first in first out (FIFO)
        //Defining a queue of int
        Queue<int> queue = new Queue<int>();
        //Adds item to the end of the queue
        queue.Enqueue(1);
        //Printing the element at the front of the queue
        Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());
        queue.Enqueue(2);
        Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());
        queue.Enqueue(3);
        queue.Dequeue(); //Removes first item in queue
        Console.WriteLine("The value at the front of the queue is {0}", queue.Peek());

        while (queue.Count > 0)
        {
            Console.WriteLine("The front value {0} was removed from the queue.", queue.Dequeue());
            Console.WriteLine("Current queue count is now {0}.", queue.Count);
        }*/

        //ReceiveOrdersFromBranch1
        static Order[] ReceiveOrdersFromBranch1()
        {
            //Creating new orders array and initializing it with some objects of type Order
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 4),
                new Order(6, 10)
            };
            return orders;
        }

        //RecieveOrdersFromBranch2 
        static Order[] ReceiveOrdersFromBranch2()
        {
            //Creating new orders array and initializing it with some objects of type Order
            Order[] orders = new Order[]
            {
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10)
            };
            return orders;
        }



    }
}