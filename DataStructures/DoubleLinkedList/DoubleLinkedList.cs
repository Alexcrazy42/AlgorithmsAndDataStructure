

DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
doubleLinkedList.Add(1);
doubleLinkedList.Add(2);
doubleLinkedList.Add(3);
doubleLinkedList.Add(4);
doubleLinkedList.Add(5);
doubleLinkedList.Add(6);
doubleLinkedList.WalkToList();


class DoubleNode<T>
{
    public DoubleNode(T data)
    {
        Data = data;
    }

    public T Data { get; set; }
    public DoubleNode<T> Next { get; set; }
    public DoubleNode<T> Prev { get; set; }
}



class DoubleLinkedList<T>
{
    DoubleNode<T> head;
    DoubleNode<T> tail;
    int count;

    public void Add(T data)
    {
        DoubleNode<T> node = new DoubleNode<T>(data);

        if (head == null)
        {
            head = node;
        }
        else
        {
            tail.Next = node;
            node.Prev = tail;
        }
        tail = node;
        count++;
    }

    public void WalkToList()
    {
        
        ConsoleKeyInfo key;
        var current = head;
        Console.WriteLine(current.Data);
        do
        {
            key = Console.ReadKey();
            if(key.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine(current.Next.Data);
                current = current.Next;
            }
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine(current.Prev.Data);
                current = current.Prev;
            }
            

        } while (key.Key != ConsoleKey.Escape);
        /*
        var current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
        */
    }
}