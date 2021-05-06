
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

            Console.ReadKey();
        }
    }
}
