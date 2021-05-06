
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            list.Add(56);
            list.Add(70);
            list.Add(90);
            list.Add(12);
            list.Add(30);
            list.Add(60);
            list.AddInReverseOrder(22);
            list.AddInReverseOrder(44);
            list.InsertAtParticularPosition(2, 12);
            list.Display();
            list.Total();
            list.DeleteFirst();
            list.DeleteLast();
            list.SearchValueInList(90);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            queue.Enqueue(12);
            queue.Enqueue(24);
            queue.Enqueue(36);
            queue.Enqueue(48);
            queue.Dequeue();
            queue.Display();
            Console.ReadKey();
        }
    }
}
