using System;

namespace SLL//singly linked list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(2);
            list.AddLast(5);
            list.AddLast(4);
            list.AddBefore(5,13);

            
        }
    }
}
