using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Queue_Using_Array
{
    class Queue
    {
        private int[] arr;
        private int front = 0, rear = -1, length = 0;
        
        public Queue(int size)
        {
            arr = new int[size];
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public bool IsFull()
        {
            return length == arr.Length;
        }

        public void First()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
                Console.WriteLine(arr[front] + " is present at front!");
        }

        public void Last()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
                Console.WriteLine(arr[rear] + " is present at rear!");
        }

        public void Display()
        {
            int j = 0;
            for(int i = front; j < length;)
            {
                Console.Write(arr[i] + " ");
                i = (i + 1) % arr.Length;
                j++;
            }
            Console.WriteLine();
        }

        public void Enqueue(int data)
        {
            if (IsFull())
                Console.WriteLine("Queue is full!");
            else
            {
                rear = (rear + 1) % arr.Length;
                arr[rear] = data;
                length++;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
            {
                front = (front + 1) % arr.Length;
                length--;
            }
        }

        static void Main(string[] args)
        {
            Queue queue = new Queue(5);
            queue.Dequeue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Display();
            queue.First();
            queue.Last();
            queue.Dequeue();
            queue.Display();
            queue.Dequeue();
            queue.Display();
            Console.ReadKey();
        }
    }
}
