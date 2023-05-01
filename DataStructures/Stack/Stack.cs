using System.IO.Pipes;

Stack<string> stack = new Stack<string>();
stack.Push("Саша");
stack.Push("Миша");
stack.Push("Миша");





public class Stack<T>
{
    public T[] items;
    public int count = 0;
    const int n = 10;

    public Stack()
    {
        items = new T[n];
    }
    public Stack(int lenght)
    {
        items = new T[lenght];
    }


    public bool IsEmpty { get { return count == 0; } }

    public int Count
    {
        get { return count; }
    }

    public void Push(T item)
    {
        if(count == items.Length)
        {
            Resize(items.Length + 10);
        }
        items[count] = item;
        count += 1;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Стек пуст");
        T item = items[--count];
        items[count] = default(T); // сбрасываем ссылку

        if (count > 0 && count < items.Length - 10)
            Resize(items.Length - 10);

        return item;
    }

    public void Resize(int max)
    {
        T[] tempItems = new T[max];
        for (int i = 0; i < count; i++)
        {
            tempItems[i] = items[i];
        }
        items = tempItems;

    }
}