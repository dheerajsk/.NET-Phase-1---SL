using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    class StackProgram
    {
        public int Length { get; set; }
        public Node First { get; set; }
        public Node Current { get; set; }

        public static void Do()
        {
            StackProgram stack = new StackProgram();
            for(int i=0; i<10; i++)
            {
                Node node = new Node();
                node.Data = i.ToString();
                stack.Push(node);
            }
            Console.WriteLine("Length of Stack is : " + stack.GetLength());
            Console.WriteLine(stack.Pop().Data);
            Console.WriteLine(stack.Pop().Data);
            Console.WriteLine("Length of Stack is : " + stack.GetLength());
            Console.WriteLine(stack.Peek().Data);
            Console.WriteLine("Length of Stack is : " + stack.GetLength());
        }

        public void Push(Node node)
        {
            node.Next = null;
            if(First is null)
            {
                First = node;
                Length = 1;
                Current = First;
                First.Prev = null;
            }
            else
            {
                Current.Next = node; // Add node to next location of last added node.
                node.Prev = Current; // Prev pointer will point to current node.
                Current = node; // Current pointer will point new node.
                Length++;
            }
        }

        public Node Pop()
        {
            if(Current is null)
            {
                return null;
            }
            else if (Current == First)
            {
                Node node = Current;
                Current = null;
                First = null;
                Length = 0;
                return node;
            }
            else
            {
                Node node = Current;
                Current = Current.Prev;
                Current.Next = null;
                Length--;
                return node;
            }
        }

        public Node Peek()
        {
            if (Current is null)
            {
                return null;
            }
            return Current;
        }

        public int GetLength()
        {
            return Length;
        }

        public Node GetFirst()
        {
            Current = First;
            return this.First;
        }
    }
}
