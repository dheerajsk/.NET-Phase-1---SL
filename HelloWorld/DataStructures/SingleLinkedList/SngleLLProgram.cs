using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SingleLinkedList
{
    class SingleLLProgram
    {
        public Node Current { get; set; }
        public Node Root { get; set; }
        public int Length { get; set; }

        public static void Do()
        {
            SingleLLProgram list = new SingleLLProgram();
            Node root = new Node();
            root.Data = "root";
            list.Add(root);
            for(int i=0; i<10; i++)
            {
                Node node = new Node();
                node.Data = i.ToString();
                list.Add(node);
            }
            Console.WriteLine("Length of list is " + list.GetLength());

            Node nodeToRead = list.GetRoot();
            while (nodeToRead != null)
            {
                Console.WriteLine(nodeToRead.Data);
                nodeToRead = list.GetNext();
            }
        }

        public void Add(Node node)
        {
            node.Next = null;
            if(Root is null) // If List is empty
            {
                Root = node; // New node becomes root
                Length = 1; // Lenght of list is 1
                Current = Root; // Current points to newly added node.
            }
            else // If list already has few nodes
            {
                Current.Next = node; // Add new node next to current node.
                Current = node; // Newly added node becomes current node.
                Length++; // Increament the length of list
            }

        }

        public Node GetCurrent()
        {
            return this.Current;
        }

        public Node GetRoot()
        {
            Current = Root;
            return this.Root;
        }

        public Node GetNext()
        {
            if (Current.Next != null)
            {
                Current = Current.Next;
                return Current;
            }
            else
            {
                return null;
            }
        }

        public int GetLength()
        {
            return this.Length;
        }
    }
}
