using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson019_Task1
{
    class MyStack<T>
    {
        private T[] array = new T[10];
        private int i = 0;


        public int Count
        {
            get
            {
                return array.Length;
            }
        }

        public void Push(T item)
        {
            if (i >= array.Length)
            {
                Console.WriteLine("There are max count of items in the stack!");
                return;
            }
            array[i] = item;
            i++;
        }

        public T Pop()
        {
            int j = --i;
            if (i <= -1)
            {
                i = 0;
                Console.WriteLine("The stack is empty!");
                return default;
            }
            T temp = array[j];
            array[j] = default;
            return temp;
        }

        public void Clear()
        {
            array = new T[array.Length];
            Console.WriteLine("The stack is empty!");
        }

        public bool Contains(T item)
        {

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

