using System;

namespace SinglyLinkedListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SingleLinkedList<int>();

            list.AddFirst(5);
            list.AddLast(6);
            list.AddBefore(list.Find(6), 9);
            list.AddLast(18);
            ;
        }
    }
}
