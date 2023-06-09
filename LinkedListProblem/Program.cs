﻿using System.Collections;
using System.Collections.Generic;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem");
            Console.WriteLine("\n1.CreateLinkedList \n2.AddFirstLinkedList \n3.AppendLinkedList \n4.InsertLinkedList \n5.DeleteFirstElement" +
                             "\n6.DeleteLastElement \n7.SearchNodeElement \n8.InsertNodeLinkedList \n9.DeleteElementAndFindSize" +
                             "\n10.SortLinkedListInAscendingOrder");
            LinkedList list = new LinkedList();
            SortedLinkedList list1 = new SortedLinkedList();
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Creating a linked list to add data");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    break;
                case 2:
                    Console.WriteLine("Adding Data in Linked List in first position");
                    list.AddFirst(70);
                    list.AddFirst(30);
                    list.AddFirst(56);
                    list.Display();
                    break;
                case 3:
                    Console.WriteLine("Append Data in Linked List in last position");
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Display();
                    break;
                case 4:
                    Console.WriteLine("Insert Data in Linked List at specific index");
                    list.Append(56);
                    list.Append(70);
                    list.InsertAtParticularPosition(2, 30);
                    list.Display();
                    break;
                case 5:
                    Console.WriteLine("Delete first element in Linked List ");
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Display();
                    list.RemoveFirstNode();
                    list.Display();
                    break;
                case 6:
                    Console.WriteLine("Delete last element in linked list ");
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Display();
                    list.RemoveLastNode();
                    Console.WriteLine("Remove last node from linked list ");
                    list.Display();
                    break;
                case 7:
                    Console.WriteLine("Search Linked List to find node ");
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Search(30);
                    list.Display();
                    break;
                case 8:
                    Console.WriteLine("Insert Node After Searching linked list");
                    list.Append(56);
                    list.Append(30);
                    list.Append(70);
                    list.Search(30);
                    list.InsertAtParticularPosition(3, 40);
                    Console.WriteLine("After inserting the element");
                    list.Display();
                    break;
                case 9:
                    Console.WriteLine("Delete the element and find Size of the linked list ");
                    list.Append(56);
                    list.Append(30);
                    list.Append(40);
                    list.Append(70);
                    list.Size();
                    list.Delete(40);
                    Console.WriteLine("After removing an element");
                    list.Display();
                    list.Size();
                    break;
                case 10:
                    Console.WriteLine("Creating a ordered linked list and add sort element in ascending order");
                    list1.Add(56);
                    list1.Add(30);
                    list1.Add(40);
                    list1.Add(70);
                    Console.WriteLine("After sorting the element in ascending");
                    list1.Display();
                    break;
                default:
                    Console.WriteLine("Please enter correct option ");
                    break;
               
            }
        }
    }
}