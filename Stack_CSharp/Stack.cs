using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_CSharp
{
    class Stack
    {
        int[] stack;
        int top;
        public Stack(int size)
        {
            stack = new int[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == stack.Length - 1;
        }

        public int Size()
        {
            return top + 1;
        }

        public void Push(int data)
        {
            if (IsFull())
                Console.WriteLine("Stack is full!");
            else
                stack[++top] = data;
        }

        public void Pop()
        {
            if (IsEmpty())
                Console.WriteLine("Stack is empty!");
            else
                Console.WriteLine("{0} deleted!", stack[top--]);
        }

        public void Peek()
        {
            if (IsEmpty())
                Console.WriteLine("Stack is empty!");
            else
                Console.WriteLine("{0} is at the top!", stack[top]);       
        }

        public void Display()
        {
            for(int i = top; i >= 0; i--)
            {
                Console.Write(stack[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            stack.Pop();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.Pop();
            stack.Display();
            Console.ReadKey();
        }
    }
}
