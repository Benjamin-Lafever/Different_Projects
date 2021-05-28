using System;
using System.Collections.Generic;
using System.Collections;

// LinkedList<T> Class is present in System.Collections.Generic namespace, This generic type allows 
// fast inserting and removing of elements. It implements a classic linked list. Each object is separately allocated. In 
// LinkedList, certain operations do not require the whole collection to be copie. But in many common cases LinkedList hinders
// performance 

// Characteristics of linked list class:
// - LinkedList<T> is a general-purpose linked list. It supports enumerators 
// - Insertion and removal are 0(1) operations 
// - You can remove nodes and reinsert them, either in the same or in another list
// - Because the list also maintains an internal count, getting the count properly is an 0(1) operation
// - Each node in a LinkedList<T> object is of type LinkedList<T> 
// - The LinkedList class does not support chaining, splitting, cycles or other features that can leave the list in an inconsistent state
// - If the Linked List is empty, the first and last properties contain null
// - The Linked List is doubly linked, therefore each node points forward to the next node and backwards to the previous node

// code to create a C# doubly Linkedlist
namespace LinkedList_
{
    class Program
    {
        // Driver code
        static void Main(string[] args)
        {
            //creating a LinkedList of strings
            LinkedList<string> myList = new LinkedList<string>();

            //Adding nodes in LinkedList
            myList.AddLast("Geeks");
            myList.AddLast("for");
            myList.AddLast("Data Structures");
            myList.AddLast("Nodia");

            // To check if LinkedList is empty or not
            if (myList.Count > 0)
            {
                Console.WriteLine("LinkedList is not empty");
            }
            else
                Console.WriteLine("LinkedList is empty");


            // --------- Count Property -------------
            //to get the first node of my linked list
            if (myList.Count > 0)
            {
                Console.WriteLine(myList.First.Value);
            }
            else
                Console.WriteLine("Linked List is empty");

            // ---------- Last Property -------------
            //to get the last node of my linked list
            if (myList.Count > 0)
            {
                Console.WriteLine(myList.Last.Value);
            }
            else
                Console.WriteLine("Linked List is empty");

            //To check if a value is in a linked list
            Console.WriteLine(myList.Contains("Nodia"));

            //C# code to remove the specified node
            // from the linked list 

            //To get the count of nodes in the Linked list 
            // before removing the first node 
            Console.WriteLine("Total nodes in myList are: " + myList.Count);

            //Displaying the nodes in myList
            foreach(string s in myList)
            {
                Console.WriteLine(s);
            }

            // removing the first node in LinkedList
            myList.RemoveFirst();
            //or myList.Remove(myList.First);

            //To get the count of nodes in LinkedList
            //after removing the first node 
            Console.WriteLine("Total nodes in myList are: " + myList.Count);

            //Displaying the nodes
            foreach(string s in myList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
