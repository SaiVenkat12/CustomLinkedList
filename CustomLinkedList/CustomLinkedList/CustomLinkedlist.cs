using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class CustomLinkedlist
    {
        public Node head;
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} inserted into the LinkedList", head.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} inserted into the LinkedList", newNode.data);
            }
        }
        public void AddFist(int data)
        {
            Node newNode = new Node(data);           
            newNode.next = head;
            head= newNode;
            Console.WriteLine("{0} inserted into the LinkedList", newNode.data);
        }
        public void Append(int data)
        {
            Add(data);
        }
        public void InsertAtAnyPoint(int data,int data2)
        {
            Node newNode = new Node(data);
            Node temp= head;
            while(temp != null)
            {
                if(temp.data==data2)
                {                    
                    newNode.next = temp.next;
                    temp.next = newNode;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
