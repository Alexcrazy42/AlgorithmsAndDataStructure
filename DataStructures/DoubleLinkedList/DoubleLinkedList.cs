

DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
doubleLinkedList.Add(1);
doubleLinkedList.Add(2);
doubleLinkedList.Add(3);
doubleLinkedList.Add(4);
doubleLinkedList.Add(5);
doubleLinkedList.Add(6);
doubleLinkedList.Delete(3);
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


    public void Delete(T data)
    {
        DoubleNode<T> prev = null;
        DoubleNode<T> cur = head;

        while (cur != null)
        {
            if (cur.Data.Equals(data))
            {
                if (prev == null)
                {
                    head = cur.Next;
                }
                else
                {
                    prev.Next = cur.Next;
                    cur.Next.Prev = prev;
                }
            }
            prev = cur;
            cur = cur.Next;
        }

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
                if (current.Next != null)
                {
                    Console.WriteLine(current.Next.Data);
                    current = current.Next;
                }
                else
                {
                    Console.WriteLine($"Попытка выйти за пределы массива справа! Ты все еще в {current.Data}");
                }

            }
            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (current.Prev != null)
                {
                    Console.WriteLine(current.Prev.Data);
                    current = current.Prev;
                }
                else
                {
                    Console.WriteLine($"Попытка выйти за пределы массива слева! Ты все еще в {current.Data}");
                }
                
            }
            

        } while (key.Key != ConsoleKey.Escape);
        
    }
}