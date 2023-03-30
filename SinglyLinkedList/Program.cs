using SinglyLinkedList;

internal class Program
{
    private static void Main(string[] args)
    {
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

        int[] indexes = { 0, 1, 2, 3, 4, 5, 6};
        foreach(int i in indexes)
        {
            Console.WriteLine(linked.GetValue(i));
        }

        foreach (int i in indexes)
        {
            Console.WriteLine(linked2.GetValue(i));
        }

        linked.RemoveLast();
        foreach (int i in indexes)
        {
            Console.WriteLine(linked.GetValue(i));
        }

        linked2.RemoveFirst();
        foreach (int i in indexes)
        {
            Console.WriteLine(linked2.GetValue(i));
        }

    }
}