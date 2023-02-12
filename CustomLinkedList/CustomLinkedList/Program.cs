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
            list.AddFist(70);
            list.AddFist(30);
            list.AddFist(56);
            list.Display();

            Console.ReadLine();
        }
    }
}
