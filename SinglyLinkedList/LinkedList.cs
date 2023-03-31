using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class LinkedList
    {
        //properties
        public Node? Head { get; set; }
        //public Node? Tail { get; set; }

        private int count; // for keeping track how many nodes there are in the linked list

        //constructor
        /// <summary>
        /// creates a linked list with its default head to be a null node.
        /// </summary>
        public LinkedList()
        {
            // here head is a Node with a null value
            Head = null;
            //since we start with a head that is null, 
            count = 0;
        }


        //methods
        ///<summary>
        ///adds a node at the beginning of the linked list
        /// </summary>
        public void AddFirst(string inputVal)
        {

            //creates a new node and assign the input value as its value.
            Node newNode= new Node(inputVal);

            //assign the head which currently null, as the next node
            newNode.NextNode = Head;

            //assign newNode as the head of the linkedlist
            Head = newNode;

            count++;
        }


        ///<summary>
        /// adds a node at the end of the list
        /// </summary>
        public void AddLast(string inputVal)
        {
            //make a new node with the inputvalue
            Node newNode= new Node(inputVal);

            //if linked list is empty, just add the new node
            if(Head==null)
            {
                newNode.NextNode = Head;
                Head = newNode;
            }
            else
            {
                // go through all the nodes until there is no next node or if it is null
             
                // make the next node the head so we can get the nextnode and check that too
                Node newNewNode = new Node();
                newNewNode = Head;
                while (newNewNode.NextNode != null)
                {
                    newNewNode = newNewNode.NextNode;
                }
                newNewNode.NextNode = newNode;
                count++;
            }
           
        }

        ///<summary>
        /// Removes the first node in the list
        /// </summary>
        public void RemoveFirst()
        {
            //if linked list is not empty
            if(Head != null)
            {
            //make a new node that will be head
            Node? newnewNode = Head;
            // get the second node and make it the first
            Head = Head.NextNode;
            //make the new node null, essentially unlinking the old head
            newnewNode = null;
            count--;    
            }
            else
            {
                throw new InvalidOperationException("You have an empty linked list");
            }
        }


        ///<summary>
        ///Removes the last node in the list
        /// </summary>
        ///

        public void RemoveLast()
        {
            if (Head != null)
            {
                // if node next to head is null then just empty the list
                if(Head.NextNode!= null)
                {
                    Head = null;
                }
                // if node next to head is not null then go through the list till the node befor the last one
                else
                {
                    Node? currentNode = Head; //start at the head
                    Node currentNode2 = Head; // need another to track the next node rightbehind current node
                    while(currentNode.NextNode != null)
                    {
                        // next node becomes the current node, going through the list
                        currentNode2 = currentNode;
                        currentNode = currentNode.NextNode;
                    }
                    // at this point, currentnode2 is the second last node
                    // assign currentnode2 to null, so we can git rid of currentnode which is the last node
                    currentNode2.NextNode = null;
                    currentNode = null;
                    count--;

                }             
            }
            else
            {
                throw new InvalidOperationException("You have an empty linked list");
            }

        }

        /// <summary>
        /// Retrieves the value of the node at the given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetValue(int index)
        {
            //start from the head, go through the list and compare index
            Node? currentNode = new Node();
            currentNode = Head;
            int currentIndex = 0;
            string value = "";
            while(currentNode != null && currentIndex < index)
            {
                currentIndex++;
                //go to next node
                value = currentNode.Value;
                currentNode = currentNode.NextNode;
                    
            }
            // at this point, our current node is not null and has the index matching the input index
            return value;
            
        }

        /// <summary>
        /// gets the size of the list
        /// </summary>
        /// <returns> the size of the list</returns>
        public int GetSize()
        {
            return count;
        }


        ///<summary>
        ///Displays all the values in the linked list
        /// </summary>
        public void DisplayValues()
        {
            Node currentNode = Head; // start at the head

            if(currentNode != null)
            {
                while(currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.NextNode;
                }
            }
            else
            {
                Console.WriteLine("You have an empty linked list");
            }
        }




    }
}
