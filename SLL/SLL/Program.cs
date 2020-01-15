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
            list.AddBefore(list.Search(5),13);
            list.AddLast(20);
            list.AddAfter(list.Search(4), 12);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            list.Remove(5);
            list.RemoveLast();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
