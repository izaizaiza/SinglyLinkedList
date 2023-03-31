using NUnit.Framework.Constraints;
using SinglyLinkedList;
using System;
using System.Globalization;
using System.Reflection;

namespace SinglyLinkedListTest
{
    public class SLLTests
    {
        //SinglyLinkedList.LinkedList linL;

        [SetUp]
        
        public void Setup()
        {
            
        }


        [Test]
        public void Test_AddFirst_ReturnsVoid()
        {
            LinkedList link = new LinkedList();

            string[] names = {"Dave Daverson" , "Sam Sammerson", "Bob Bobberson",
            "Jane Doe","John Smith","Joe Schmoe","Joe Blow"};
 
            //execute
            foreach(string name in names)
            {
                link.AddFirst(name);
            }

            string[] expNodeValues = {"Joe Blow","Joe Schmoe","John Smith",
                "Jane Doe","Bob Bobberson","Sam Sammerson","Dave Daverson"};

 
            int[] indexes = { 1, 2, 3, 4, 5, 6, 7 };
            foreach(int index in indexes)
            {
                Assert.That(link.GetValue(index), Is.EqualTo(expNodeValues[index - 1]));
            }
            
        }

        [Test]
        public void Test_AddLast_ReturnsVoid()
        {
            LinkedList link = new LinkedList();
            string[] names = {"Dave Daverson" , "Sam Sammerson", "Bob Bobberson",
            "Jane Doe","John Smith","Joe Schmoe","Joe Blow"};

            //execute
            foreach (string name in names)
            {
                link.AddLast(name);
            }
            // recall, that our 'index' for the linked list technically doesnt start at 0, rather at 1.
            string expValue = "Joe Blow";
            string actValue = link.GetValue(7);

            Assert.That(actValue, Is.EqualTo(expValue));
        }


        [Test]
        public void Test_RemoveFirst_ReturnsVoid()
        {
            LinkedList link = new LinkedList();

            string[] names = {"Dave Daverson" , "Sam Sammerson", "Bob Bobberson",
            "Jane Doe","John Smith","Joe Schmoe","Joe Blow"};

            //execute
            foreach (string name in names)
            {
                link.AddFirst(name);
            }

            // now remove the first
            link.RemoveFirst();
            // recall, that our 'index' for the linked list technically doesnt start at 0, rather at 1.
            string expValue = "Joe Schmoe";
            string actValue = link.GetValue(1);
            Assert.That(actValue, Is.EqualTo(expValue));
        }

        [Test]
        public void Test_RemoveLast_ReturnsVoid()
        {
            LinkedList link = new LinkedList();
            string[] names = {"Dave Daverson" , "Sam Sammerson", "Bob Bobberson",
            "Jane Doe","John Smith","Joe Schmoe","Joe Blow"};

            foreach (string name in names)
            {
                link.AddLast(name);
            }
            link.RemoveLast();
            // recall, that our 'index' for the linked list technically doesnt start at 0, rather at 1.
            string expValue = "Joe Schmoe";
            string actValue = link.GetValue(6);

            Assert.That(actValue, Is.EqualTo(expValue));

        }

        [Test]
        public void Test_GetValue_ReturnsString()
        {
            LinkedList link = new LinkedList();

            string[] names = {"Dave Daverson" , "Sam Sammerson", "Bob Bobberson",
            "Jane Doe","John Smith","Joe Schmoe","Joe Blow"};
            foreach (string name in names)
            {
                link.AddLast(name);
            }
            string expValue = "Sam Sammerson";
            string actValue = link.GetValue(2);

            Assert.That(actValue, Is.EqualTo(expValue));
        }

        //[TearDown]
        

    }
}