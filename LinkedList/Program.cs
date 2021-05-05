using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();
            list.Add(10);
            //list.Add(30);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            Console.WriteLine("************");
           // list.InsertAtPaticularPosition(3, 30);
            list.Display();
            list.DeleteFirst();
            Console.WriteLine("************");
            list.Display();
            list.DeleteLast();
            Console.WriteLine("************");
            list.Display();
            Console.ReadKey();


        }
    }
}
