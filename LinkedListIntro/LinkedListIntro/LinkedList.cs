using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedListIntro
{
    class SingleLinkedList<T>
    {
        int size = 0;
        Node<T> head;
        public SingleLinkedList()
        {

        }

        public void AddFirst(T value)
        {
            if (size == 0)
            {
                head = new Node<T>(value);
                size++;
            }
            else
            {
                Node<T> temp = new Node<T>(value);
                temp.nextNode = head;
                head = temp;
                size++;
            }
        }

        public void AddLast(T value)
        {
            if (size == 0)
            {
                head = new Node<T>(value);
                size++;
            }
            else
            {
                Node<T> current = head;

                while (current.nextNode != null)
                {
                    current = current.nextNode;
                }

                current.nextNode = new Node<T>(value);
                size++;
            }

        }

        public Node<T> Find(T node)
        {
            Node<T> temp = head;
            while(temp.nextNode != null)
            {
                if(temp.value.Equals(node))
                {
                    return temp;
                }
                temp = temp.nextNode;
            }
            return null;
        }

        public void AddAfter(Node<T> nodeToAddAfter, T value)
        {
            if(nodeToAddAfter == null)
            {
                AddLast(value);
                return;
            }
            
            Node<T> newNode = new Node<T>(value);
            newNode.nextNode = nodeToAddAfter.nextNode;
            nodeToAddAfter.nextNode = newNode;
            size++;
        }

        public void AddBefore(Node<T> nodeToAddBefore, T value)
        {
            if (nodeToAddBefore == null)
            {
                AddLast(value);
                return;
            }
            if(nodeToAddBefore == head)
            {
                AddFirst(value);
                return;
            }

            Node<T> temp = head;

            while (temp.nextNode != nodeToAddBefore)
            {
                temp = temp.nextNode;
            }

            Node<T> newNode = new Node<T>(value);

            newNode.nextNode = nodeToAddBefore;

            temp.nextNode = newNode;
            size++;
        }

        // a way but assumes user knows position.
        //public void AddBefore(int position, T value)
        //{

        //    Node<T> temp = head;
        //    for (int i = 0; i < position - 1; i++)
        //    {
        //        temp = temp.nextNode;
        //    }
        //    Node<T> current = new Node<T>(value);
        //    current.nextNode = temp.nextNode;
        //    temp.nextNode = current;
        //    size++;

        //}


    }
}
