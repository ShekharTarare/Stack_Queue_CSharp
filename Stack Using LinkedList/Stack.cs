using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Using_LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int _data)
        {
            data = _data;
        }
    }
    class Stack
    {
        private Node top;
        private int size;
        public Stack()
        {
            size = 0;
            top = null;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Length()
        {
            return size;
        }

        public void Display()
        {
            Node temp = top;
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
                top = newNode;
            else
            {
                newNode.next = top;
                top = newNode;
            }
            size++;
        }

        public void Pop()
        {
            if (IsEmpty())
                Console.WriteLine("Stack is Empty!");
            else
            {
                Console.WriteLine(top.data + " deleted!");
                top = top.next;
                size--;
            }            
        }

        public void Peek()
        {
            if (IsEmpty())
                Console.WriteLine("Stack is Empty!");
            else
                Console.WriteLine(top.data + " as at the top!");
        }

        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(5);
            s.Push(3);
            s.Display();
            Console.WriteLine("Size: " + s.Length());
            s.Pop();
            Console.WriteLine("IsEmpty: " + s.IsEmpty());
            s.Pop();
            Console.WriteLine("IsEmpty: " + s.IsEmpty());
            s.Push(7);
            s.Push(9);
            s.Display();
            s.Peek();
            s.Display();
            Console.ReadKey();
        }
    }
}
