using System;
using System.Collections.Generic;
using System.Text;

namespace SLL
{
    class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int count { get; private set; }


        public void AddFirst(T Value)
        {
            if(Head == null)
            {
                Head = new Node<T>(Value);
                Tail = Head;
                count++;
            }
            else
            {
                Node<T> NodeToAdd = new Node<T>(Value);
                NodeToAdd.Next = Head;
                Head = NodeToAdd;
                count++;
            }

        }

       public  void AddLast(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
                count++;
            }
            else
            {
                //Node<T> NodeToAdd = Head;
                //while(NodeToAdd.Next != null)
                //{
                //    NodeToAdd = NodeToAdd.Next;
                //}

                //NodeToAdd.Next = new Node<T>(Value);
                //count++;

                Tail.Next = new Node<T>(value);
                Tail = Tail.Next;
                count++;
            }
        }

        public void AddBefore(Node<T> nodeToAddBefore, T value)
        {
            //if heads null, and want to add before head
            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
                count++;
            }
            else if (nodeToAddBefore == Head)
            {
                AddFirst(value);
            }
            else
            {

                Node<T> previousNode = Head;
                while (previousNode.Next != nodeToAddBefore)
                {
                    previousNode = previousNode.Next;
                }

                Node<T> temp = new Node<T>(value);
                temp.Next = nodeToAddBefore;
                previousNode.Next = temp;
                count++;
            }
        }

    }
}
