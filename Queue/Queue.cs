Queue<string> queue = new Queue<string>();
queue.Enqueue("Ann");
queue.Enqueue("Lisa");

var current = queue.head;
do
{
    Console.WriteLine(current);
    current = current.Next;
} while (current != null);


class Node<T>
{
    public Node(T data)
    {
        Data = data;
    }
    public T Data { get; set; }
    public Node<T> Next { get; set; }
}

class Queue<T>
{
    public Node<T> head; 
    public Node<T> tail;
    int count = 0; 


    public void Enqueue(T data)
    {
        Node<T> node = new Node<T>(data);
        Node<T> tempNode = tail;
        tail = node;
        if (count == 0)
            head = tail;
        else
            tempNode.Next = tail;
        count++;
    }
}

