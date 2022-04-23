using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Ended_Queue_Using_LinkedList
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

        public void AddFromFront(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
                front = rear = newNode;
            else
            {
                newNode.next = front;
                front = newNode;
            }
            size++;
        }

        public void AddFromRear(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
                front = newNode;
            else
                rear.next = newNode;
            rear = newNode;
            size++;
        }

        public void RemoveFromFront()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
            {
                Console.WriteLine(front.data + " deleted!");
                front = front.next;
                if (IsEmpty())
                    rear = null;
                size--;
            }
        }

        public void RemoveFromRear()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
            {
                Console.WriteLine(rear.data + " deleted!");
                int i = 1;
                Node temp = front;
                while(i < size - 1)
                {
                    temp = temp.next;
                    i++;
                }
                rear = temp;
                rear.next = null;
                size--;
            }
        }

        public void First()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
                Console.WriteLine(front.data + " is the first!");
        }

        public void Last()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty!");
            else
                Console.WriteLine(rear.data + " is the last!");
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
            Queue d = new Queue();
            d.AddFromFront(5);
            d.AddFromFront(3);
            d.AddFromRear(7);
            d.AddFromRear(12);
            d.Display();
            Console.WriteLine("Size: " + d.Length());
            d.RemoveFromFront();
            d.RemoveFromRear();
            d.Display();
            d.First();
            d.Last();
            Console.ReadKey();
        }
    }
}
