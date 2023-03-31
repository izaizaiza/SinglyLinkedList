using SinglyLinkedList;

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
                Assert.That(expNodeValues[index - 1], Is.EqualTo(link.GetValue(index)));
            }
            
        }

        //[Test]

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

            // since were adding last, the order it was added should be the same order as when its added to the linked list
            int[] indexes = {0, 1, 2, 3, 4, 5, 6};
            foreach (int index in indexes)
            {
                Assert.That(names[index - 1], Is.EqualTo(link.GetValue(index)));
            }

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

            string[] expNodeValues = {"Joe Schmoe","John Smith",
                "Jane Doe","Bob Bobberson","Sam Sammerson","Dave Daverson"};

            int[] indexes = {0, 1, 2, 3, 4, 5, 6};
            foreach (int index in indexes)
            {
                Assert.That(expNodeValues[index], Is.EqualTo(link.GetValue(index)));
            }

        }

        //[Test]
        ////[TestCase("")]
        //public void Test_RemoveLast_ReturnsVoid()
        //{
        //    Assert.Pass();
        //}

        //[Test]
        ////[TestCase("")]
        //public void Test_GetValue_ReturnsString()
        //{
        //    Assert.Pass();
        //}


    }
}