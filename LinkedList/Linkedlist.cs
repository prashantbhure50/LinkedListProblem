using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Linkedlist
    {
        internal Node head;
        internal Node tail;

        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list",node.data);

        }
        internal void Display()
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linkedlist is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        internal Node InsertAtPaticularPosition(int position, int data)
        {
            if(position<1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;

                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");

            }
            return head;

        }
        internal void Total()
        {
            int Total = 0;
            Node temp = this.head;
            while(temp !=null)
            {
                Total = Total + temp.data;
                temp = temp.next;
            }
            Console.WriteLine(Total);

        }
        internal Node DeleteFirst()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        internal Node DeleteLast()
        {
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while(NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;


        }
        internal Node SearchValueInList(int value)
        {
            while (this.head != null)
            {
                if(this.head.data == value)
                {
                    return this.head;
                    
                }
                this.head = this.head.next;
            }
            return null;
        }
        internal void DeleteAtPaticularPosition(int data)
        {
            
                Node temp = head, prev = null;
                while (temp != null && temp.data != data)
                {
                    prev = temp;
                    temp = temp.next;
                }
            prev.next = temp.next;

        }    }
}
