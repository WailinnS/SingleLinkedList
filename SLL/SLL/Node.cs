using System;
using System.Collections.Generic;
using System.Text;

namespace SLL
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T Value)
        {
            this.Value = Value;
            Next = null;
        }

        public Node(T Value, Node<T> Next)
        {
            this.Value = Value;
            this.Next = Next;
        }
    }
}
