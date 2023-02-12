using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");
            CustomLinkedlist list = new CustomLinkedlist();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

            Console.ReadLine();
        }
    }
}
