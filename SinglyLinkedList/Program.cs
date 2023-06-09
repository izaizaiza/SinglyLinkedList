﻿using SinglyLinkedList;

internal class Program
{
    private static void Main(string[] args)
    {
        ///<summary>
        /// to quickly check if logic works
        /// </summary>
        Console.WriteLine("Hello, World!");

        SinglyLinkedList.LinkedList linked = new SinglyLinkedList.LinkedList();
        linked.AddFirst("Dave Daverson");
        linked.AddFirst("Sam Sammerson");
        linked.AddFirst("Bob Bobberson");
        linked.AddFirst("Jane Doe");
        linked.AddFirst("John Smith");
        linked.AddFirst("Joe Schmoe");
        linked.AddFirst("Joe Blow");

        SinglyLinkedList.LinkedList linked2 = new SinglyLinkedList.LinkedList();
        linked2.AddLast("Dave Daverson");
        linked2.AddLast("Sam Sammerson");
        linked2.AddLast("Bob Bobberson");
        linked2.AddLast("Jane Doe");
        linked2.AddLast("John Smith");
        linked2.AddLast("Joe Schmoe");
        linked2.AddLast("Joe Blow");


        //check if AddFirst works
        linked.DisplayValues();
        //Console.WriteLine(linked.GetValue(3));
        Console.WriteLine("\n");

        //check if AddLast works
        linked2.DisplayValues();
        //Console.WriteLine(linked2.GetValue(4));

        //check if remove first works
        Console.WriteLine("\n");
        linked.RemoveFirst();
        linked.DisplayValues();

        int[] indexes = { 0, 1, 2, 3, 4, 5, 6 };
        foreach(int i in indexes)
        {
            Console.WriteLine(linked.GetValue(i));
        }
        //Console.WriteLine(linked.GetValue(1));
        //Console.WriteLine(linked.GetValue(2));

        //check if remove last works
        Console.WriteLine("\n");
        linked.RemoveLast();
        linked.DisplayValues();
        //Console.WriteLine(linked.GetValue(1));
        //Console.WriteLine(linked.GetValue(2));
        //Console.WriteLine(linked.GetValue(3));
        //Console.WriteLine(linked.GetValue(4));
        //Console.WriteLine(linked.GetValue(5));


        //Console.WriteLine(linked.GetValue(6));
        //int[] indexes = { 0, 1, 2, 3, 4, 5 };
        ////print to check
        //foreach (int i in indexes)
        //{
        //    Console.WriteLine(linked.GetValue(i));
        //}

    }
}