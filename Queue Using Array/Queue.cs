using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Using_Array
{
    class Queue
    {
        int[] queue;
        int front, rear, size;
        public Queue(int size)
        {
            queue = new int[size];
            front = 0;
            rear = 0;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return rear == queue.Length;
        }

        public int Length()
        {
            return size;
        }

        public void Enqueue(int data)
        {
            if (IsFull())
                Console.WriteLine("Queue is full!");
            else
            {
                queue[rear++] = data;
                size++;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
            {
                Console.WriteLine(queue[front++] + " deleted!");
                size--;
            }
        }

        public void First()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
                Console.WriteLine(queue[front] + " is at the front!");
        }

        public void Display()
        {
            for(int i = front; i < rear; i++)
            {
                Console.Write(queue[i] + " ");
            }
            Console.WriteLine();
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
            queue.Dequeue();
            queue.Display();
            queue.Dequeue();
            queue.Display();
            Console.ReadKey();
        }
    }
}
