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
            list.InsertAtPaticularPosition(3, 30);
            list.Display();
            list.DeleteFirst();
            Console.WriteLine("************");
            list.Display();
            list.DeleteLast();
            Console.WriteLine("************");
            list.Display();
            list.SearchValueInList(30);
            Console.WriteLine("************");
            list.Display();
             list.DeleteAtPaticularPosition(20);
            Console.WriteLine("************");
            list.Display();
            Console.ReadKey();


            //LinkedListStack stack = new LinkedListStack();
            //stack.Push(56);
            //stack.Push(30);
            //stack.Push(70);
            //stack.Display();
            //Console.WriteLine("************");
            //stack.Peek();
            //stack.Display();
            //Console.WriteLine("************");
            //stack.Pop();
            //stack.Display();
            //Console.WriteLine("************");
            //stack.IsEmpty();
            //stack.Display();
            //Console.ReadKey();

            //LinkedListQueue Queue = new LinkedListQueue();

            //Queue.Enqueue(56);
            //Queue.Enqueue(30);
            //Queue.Enqueue(70);
            //Queue.Display();
            //Console.WriteLine("************");
            //Queue.Dequeue();
            //Queue.Display();
            //Console.ReadKey();


        }
    }
}
