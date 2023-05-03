string s = "(3 + 45)";

Dictionary<char, char> dic = new Dictionary<char, char>()
{
    { ')', '(' },
    { ']', '[' }, 
    { '}', '{' },
};
var stack = new Stack<string>();

foreach (char s1 in s)
{
    if (dic.ContainsValue(s1))
    {
        stack.Push(s1.ToString());
    }
    else if (!stack.IsEmpty && dic.ContainsKey(s1) && stack.Last() == dic[s1].ToString())
    {
        stack.Pop();
    }
    else if(!stack.IsEmpty && dic.ContainsKey(s1) && stack.Last() != dic[s1].ToString())
    {
        stack.Push(s1.ToString());
    }
    
}

Console.WriteLine(s);
if (stack.IsEmpty)
{
    Console.WriteLine("Correct placement!");
}
else
{
    Console.WriteLine("Uncorrect placement!");
}


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

    public T Last()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Стек пуст");
        else
        {
            return items[count-1];
        }
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