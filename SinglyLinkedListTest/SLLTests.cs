using SinglyLinkedList;

namespace SinglyLinkedListTest
{
    public class SLLTests
    {
        SinglyLinkedList.LinkedList linL;

        [SetUp]
        
        public void Setup()
        {
            linL = new SinglyLinkedList.LinkedList();
        }

        [Test]
        //[TestCase("")]
        
        public void Test_AddFirst_ReturnsVoid()
        {
            string expNodeValue = "Joe Blow";
            string?expNextnodeValue = null;

            string actNodeValue;
            //Assert.That(expNodeValue,actNodeValue);
        }

        [Test]
        //[TestCase("")]
        public void Test_AddLast_ReturnsVoid()
        {
            Assert.Pass();
        }


        [Test]
        //[TestCase("")]
        public void Test_RemoveFirst_ReturnsVoid()
        {
            Assert.Pass();
        }

        [Test]
        //[TestCase("")]
        public void Test_RemoveLast_ReturnsVoid()
        {
            Assert.Pass();
        }

        [Test]
        //[TestCase("")]
        public void Test_GetValue_ReturnsString()
        {
            Assert.Pass();
        }


    }
}