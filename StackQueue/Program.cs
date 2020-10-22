using System;

namespace LinkedListSatckAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List  Queue");


            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}