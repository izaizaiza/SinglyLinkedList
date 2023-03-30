using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node
    {
        // a node has a value and a reference/ pointer
        // single linked list's pointer points to the next node

        //properties
        public string? Value { get; set; }
        public Node? NextNode{ get; set; }

        //Constructor
        /// <summary>
        /// no parameter constructor of a node, with value to be null
        /// </summary>
        public Node()
        {
            Value = null;
        }

        /// <summary>
        /// takes in a string value and assigns it as the node's value
        /// </summary>
        /// <param name="value"></param>
        public Node(string value)
        {
            Value = value;
        }

        //print node's value and its next node's value
        public void PrintNode()
        {
            //Console.WriteLine($"node's value:{Value}\n" +
            //    $"next node's value:{NextNode.Value}");

            Console.WriteLine($"node's value:{Value}");
        }

        
    }
}
