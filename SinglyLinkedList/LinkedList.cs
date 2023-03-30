using System;
using System.Collections.Generic;
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
            Head = new Node();
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

            //if linked list is empty, just as the new node
            if(Head==null)
            {
                Head = newNode;
                return;
            }
            else
            {
                // go through all the nodes until there is no next node or if it is null
                if(Head.NextNode==null)
                {
                    Head.NextNode = newNode;
                }
                else
                {
                    // make the next node the head so we can get the nextnode and check that too
                    while (Head.NextNode != null)
                    {
                        Head = Head.NextNode;
                    }
                    Head.NextNode = newNode;
                    count++;
                }
            }
           
        }

        ///<summary>
        /// Removes the first node in the list
        /// </summary>
        public void RemoveFirst()
        {
            //check if linked list is empty
            if(Head!=null)
            {
                
                if (Head.NextNode == null)
                {
                    //if only one exists then the list becomes empty or have a null head
                    Head.NextNode = Head;
                }
                else
                {
                    // find the second node and make it the first
                    Node becomesFirst = Head.NextNode;
                    Node becomesScd = becomesFirst.NextNode; //second node could be null

                    Head = becomesFirst;
                    Head.NextNode = becomesScd;
                    count--;
                }
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
                if (Head.NextNode == null)
                {
                    Head = null;
                }
                else
                {
                    Node currentNode = Head;
                    while(currentNode.NextNode.NextNode != null)
                    {
                        // next node becomes the current node, going through the list
                        currentNode = currentNode.NextNode;
                    }
                    // at this point, when we found the next next node is null,
                    // assign the next node of current to be null
                    currentNode.NextNode = null;
                    count--;
                }

            }

        }

        /// <summary>
        /// Retrieves the value of the node at the given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetValue(int index)
        {
            if(Head == null)
            {
                throw new InvalidOperationException("You have an empty linked list");
            }
            else
            {
                //start from the head, go through the list and compare index
                Node currentNode = Head;
                int currentIndex = 0;
                while(currentNode != null && currentIndex < index)
                {
                    //go to next node
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }
                // at this point, our current node is not null and has the index matching the input index
                return currentNode.Value;
            }
        }

        /// <summary>
        /// gets the size of the list
        /// </summary>
        /// <returns> the size of the list</returns>
        public int GetSize()
        {
            return count;
        }




    }
}
