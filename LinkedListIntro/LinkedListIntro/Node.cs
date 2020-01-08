using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedListIntro
{
    class Node<T>
    {
        public T value;
        public Node<T> nextNode;
        public Node(T data)
        {
            value = data;
        }
    }
}
