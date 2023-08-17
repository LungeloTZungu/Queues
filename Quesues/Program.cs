using System;

namespace Quesues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(10);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            // see the queue of people
            Console.WriteLine("People in Line waiting for orders in the form of numbers : ");
            foreach(var i in queue.queueArray)
            {
                Console.WriteLine(i);
            }

            // removing from the queue
            queue.Dequeue();
            queue.Dequeue();
       
          
            Console.WriteLine("Person in front: ");

            Console.WriteLine(queue.Peek());
        }
    }
}
