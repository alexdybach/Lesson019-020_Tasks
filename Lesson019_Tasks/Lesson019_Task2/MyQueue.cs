using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson019_Task2
{
    class MyQueue<T>
    {
        private T[] array;// = new T[10];
        private int i = 0;
        //int j = 0;

        public int Count
        {
            get
            {
                return array.Length;
            }
        }

        public MyQueue(int count)
        {
            array = new T[count];
        }

        public void EnQueue(T item)
        {
            if (i >= array.Length)
            {
                Console.WriteLine("There are max count of items in the queue!");
                return;
            }
            array[i] = item;
            i++;
        }

        public T DeQueue()
        {
            if (array[0].Equals(default))
            {
                Console.WriteLine("There are no elements to delete from the queue!");
                return default;
            }
            T temp = array[0];
            array[0] = default;
            for(int k=1;k<i;k++)
            {
                array[k - 1] = array[k];
                array[k] = default;
            }
            return temp;
            //if (j >= i)
            //{
            //    Console.WriteLine("There are no elements to delete from the queue!");
            //    return default;
            //}
            //T temp = array[j];
            //array[j] = default;
            //j++;
            //return temp;
        }

        public void Print()
        {
            Console.WriteLine("Queue:");
            for (int m = 0; m < array.Length; m++)
            {
                Console.WriteLine(array[m]);
            }
        }

        public void Clear()
        {
            array = new T[array.Length];
            Console.WriteLine("The queue is empty!");
        }

        public bool Contains(T item)
        {

            for (int k = 0; k < i; k++)
            {
                if (array[k].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

