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
        LinkedList link1 = new LinkedList();
        LinkedList link2 = new LinkedList();
        string[] expValuesAddFirst;
        string[] expValuesRemoveFirst;
        string[] names;
        [Test]
        [SetUp]
        public void Setup()
        {

            names = new string[] {"Dave Daverson" , "Sam Sammerson", "Bob Bobberson",
            "Jane Doe","John Smith","Joe Schmoe","Joe Blow"};

            expValuesAddFirst = new string[] {"Joe Blow","Joe Schmoe","John Smith",
                "Jane Doe","Bob Bobberson","Sam Sammerson","Dave Daverson"};

        }


        [Test]
        public void Test_GetValue_ReturnsString()
        {
            string expValue = "Sam Sammerson";
            string actValue = link2.GetValue(2);

            Assert.That(actValue, Is.EqualTo(expValue));
        }


        [Test]
        public void Test_AddFirst_ReturnsVoid()
        {

            foreach(string name in names)
            {
                link1.AddFirst(name);
            }
 
            int[] indexes = { 1, 2, 3, 4, 5, 6, 7 };
            foreach(int index in indexes)
            {
                Assert.That(link1.GetValue(index), Is.EqualTo(expValuesAddFirst[index - 1]));
            }
            
        }

        [Test]
        public void Test_AddLast_ReturnsVoid()
        {
           
            //execute
            foreach (string name in names)
            {
                link2.AddLast(name);
            }

            string[] actValues= new string[] {link2.GetValue(1), link2.GetValue(2), link2.GetValue(3), link2.GetValue(4),
            link2.GetValue(5),link2.GetValue(6),link2.GetValue(7)};
            int numLink2Elements = link2.GetCount();

            // recall, that our 'index' for the linked list technically doesnt start at 0, rather at 1.
            //for (int i=1; i<=numLink2Elements; i++)
            //{
            //    actValues[i-1]=(link2.GetValue(i));
            //}

            Assert.That(actValues, Is.EqualTo(names));
        }


        [Test]
        public void Test_RemoveFirst_ReturnsVoid()
        {
      
            // link1 is created using AddFirst()
            // now remove the first
            link1.RemoveFirst();
            // recall, that our 'index' for the linked list technically doesnt start at 0, rather at 1.
            string[] expValues = {"Joe Schmoe","John Smith",
                "Jane Doe","Bob Bobberson","Sam Sammerson","Dave Daverson"};
            string[] actValues = {link1.GetValue(1), link1.GetValue(2) , link1.GetValue(3) , link1.GetValue(4),
            link1.GetValue(5),link1.GetValue(6)};
            Assert.That(actValues, Is.EqualTo(expValues));
        }

        [Test]
        public void Test_RemoveLast_ReturnsVoid()
        {
            // link2 created using AddLast()
            link2.RemoveLast();
            // recall, that our 'index' for the linked list technically doesnt start at 0, rather at 1.
            string[] expValues = {"Dave Daverson" , "Sam Sammerson", "Bob Bobberson",
            "Jane Doe","John Smith","Joe Schmoe"};
            string[] actValues = { link2.GetValue(1), link2.GetValue(2), link2.GetValue(3), link2.GetValue(4),
                link2.GetValue(5),link2.GetValue(6)};
            
            // already removed first name in the list, now remove the last as well
            link1.RemoveLast();
            string[] expValues1 = {"Joe Schmoe","John Smith",
                "Jane Doe","Bob Bobberson","Sam Sammerson"};
            string[] actValues1 = { link1.GetValue(1), link1.GetValue(2), link1.GetValue(3), link1.GetValue(4), link1.GetValue(5) };
            Assert.That(actValues1, Is.EqualTo(expValues1));

        }
 
    }
}