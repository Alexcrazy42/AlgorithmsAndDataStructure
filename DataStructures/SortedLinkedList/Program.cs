SortedLinkedList sortedLinkedList = new SortedLinkedList();
sortedLinkedList.Insert(2);
sortedLinkedList.Insert(4);
sortedLinkedList.Insert(1);
sortedLinkedList.Insert(-1);

var current = sortedLinkedList.head;
while (current != null)
{
    Console.WriteLine(current.Value);
    current = current.Next;
}



class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
}

class SortedLinkedList
{
    public Node head { get; set; }
    public Node tail { get; set; }
    public int count; 
    
    public SortedLinkedList(int data)
    {
        head = new Node { Value = data };
        tail = head; 
    }

    public SortedLinkedList()
    {
        head = null;
        tail = null;
    }

    public void Insert(int data)
    {

        Node node = new Node() { Value = data};
        Node prev = null;
        Node current = head;

        while (current != null && current.Value < data)
        {
            prev = current;
            current = current.Next;
        }

        if (prev == null)
        {
            head = node;
        }
        else
        {
            prev.Next = node;
        }
        node.Next = current;
    }



    public bool IsEmpty() => head == null;

}