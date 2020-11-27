using System;

namespace Lesson020_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            MyQueue<string> myQueue = new MyQueue<string>(5);

            Console.WriteLine($"Length of the stack = { myStack.Count}");
            Console.WriteLine($"Length of the queue = { myQueue.Count}");

            myStack.Push(5);
            myStack.Push(13);
            myStack.Push(1);

            myQueue.EnQueue("first");
            myQueue.EnQueue("second");
            Console.WriteLine("Deleted from the queue:");
            Console.WriteLine(myQueue.DeQueue());
            myQueue.Clear();

            Console.WriteLine("Deleted from the stack:");
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            if (myStack.Contains(2) == true)
            {
                Console.WriteLine("There is 2 in the stack:");
            }
            if (myStack.Contains(5) == true)
            {
                Console.WriteLine("There is 5 in the stack:");
            }
            Console.WriteLine("Deleted from the stack:");
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            myStack.Push(3);
            if (myStack.Contains(3) == true)
            {
                Console.WriteLine("There is 3 in the stack:");
            }
            myStack.Clear();
        }
    }
}
