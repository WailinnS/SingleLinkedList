using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SLL
{
    class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int count { get; private set; }


        public void AddFirst(T Value)
        {
            if (Head == null)
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

        public void AddLast(T value)
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

                Node<T> currentNode = Head;
                while (currentNode.Next != nodeToAddBefore)
                {
                    currentNode = currentNode.Next;
                }

                Node<T> temp = new Node<T>(value);
                temp.Next = nodeToAddBefore;
                currentNode.Next = temp;
                count++;
            }
        }

        public void AddAfter(Node<T> nodeToAddAfter, T Value)
        {
            if (Head == null)
            {
                Head = new Node<T>(Value);
                Tail = Head;
                count++;
            }
            else
            {
                Node<T> currentNode = Head;
                while (currentNode != nodeToAddAfter)
                {
                    currentNode = currentNode.Next;
                }

                Node<T> temp = new Node<T>(Value);
                temp.Next = currentNode.Next;
                currentNode.Next = temp;
                count++;

            }
        }

        public bool RemoveFirst()
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Head = Head.Next;
                count--;
                return true;
            }
        }

        public bool RemoveLast()
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Node<T> temp = Head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = null;
                Tail = temp;
                count--;
                return true;
            }
        }

        public bool Remove(T value)
        {
            if (!Contains(value))
            {
                return false;
            }

            Node<T> currentNode = Head;
            while (!currentNode.Next.Value.Equals(value))
            {
                currentNode = currentNode.Next;
            }
            Node<T> temp = currentNode.Next.Next;
            currentNode.Next = temp;
            count--;
            return true;
        }


        public bool Contains(T value)
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Node<T> nodeToLookFor = Head;
                while (nodeToLookFor != null)
                {
                    if (nodeToLookFor.Value.Equals(value))
                    {
                        return true;
                    }
                    nodeToLookFor = nodeToLookFor.Next;
                }
                return false;

            }
        }
        public Node<T> Search(T value)
        {

            Node<T> nodeToReturn = Head;
            while (nodeToReturn != null)
            {
                if (nodeToReturn.Value.Equals(value))
                {
                    return nodeToReturn;
                }
                nodeToReturn = nodeToReturn.Next;
            }
            return null;
          
             
        }

        //makes it usable with a foreach
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = Head;
            while(temp != null)
            {
                yield return temp.Value;
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
