using System;

namespace Lesson019_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack1 = new MyStack<int>();
            MyStack<string> myStack2 = new MyStack<string>();

            Console.WriteLine($"Length of the stack = { myStack1.Count}");

            myStack1.Push(5);
            myStack1.Push(13);
            myStack1.Push(1);

            myStack2.Push("first");
            myStack2.Push("second");
            Console.WriteLine("Deleted from the stack2:");
            Console.WriteLine(myStack2.Pop());
            myStack2.Clear();

            Console.WriteLine("Deleted from the stack1:");
            Console.WriteLine(myStack1.Pop());
            Console.WriteLine(myStack1.Pop());
            if (myStack1.Contains(2) == true)
            {
                Console.WriteLine("There is 2 in the stack:");
            }
            if (myStack1.Contains(5) == true)
            {
                Console.WriteLine("There is 5 in the stack:");
            }
            Console.WriteLine("Deleted from the stack1:");
            Console.WriteLine(myStack1.Pop());
            Console.WriteLine(myStack1.Pop());
            myStack1.Push(3);
            if (myStack1.Contains(3) == true)
            {
                Console.WriteLine("There is 3 in the stack:");
            }
            myStack1.Clear();
        }
    }
}
