using System;

namespace Lesson019_Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            MyQueue<int> myQueue1 = new MyQueue<int>(5);
            MyQueue<string> myQueue2 = new MyQueue<string>(5);

            Console.WriteLine($"Length of the queue = { myQueue1.Count}");

            myQueue1.EnQueue(5);
            myQueue1.EnQueue(13);
            myQueue1.EnQueue(1);
            myQueue1.Print();

            myQueue2.EnQueue("first");
            myQueue2.EnQueue("second");
            myQueue2.Print();

            Console.WriteLine("Deleted from the queue2:");
            Console.WriteLine(myQueue2.DeQueue());
            myQueue2.Print();
            myQueue2.Clear();

            Console.WriteLine("Deleted from the queue1:");
            Console.WriteLine(myQueue1.DeQueue());
            Console.WriteLine(myQueue1.DeQueue());
            myQueue1.Print();

            if (myQueue1.Contains(2) == true)
            {
                Console.WriteLine("There is 2 in the queue:");
            }
            if (myQueue1.Contains(5) == true)
            {
                Console.WriteLine("There is 5 in the queue:");
            }
            Console.WriteLine("Deleted from the queue1:");
            Console.WriteLine(myQueue1.DeQueue());
            Console.WriteLine(myQueue1.DeQueue());
            myQueue1.EnQueue(3);
            if (myQueue1.Contains(3) == true)
            {
                Console.WriteLine("There is 3 in the queue:");
            }
            myQueue1.Clear();
        }
    }
}
