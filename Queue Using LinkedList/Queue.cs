using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Using_LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int _data)
        {
            data = _data;
            next = null;
        }
    }

    class Queue
    {
        private Node front, rear;
        private int size;
        public Queue()
        {
            front = rear = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public int Length()
        {
            return size;
        }

        public void First()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
                Console.WriteLine(front.data + " is the first!");
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
                front = rear = newNode;
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            size++;
        }

        public void Dequeue()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
            {
                Console.WriteLine(front.data + " deleted!");
                front = front.next;
                size--;
            }
        }

        public void Display()
        {
            Node temp = front;
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Queue queue = new Queue();
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
