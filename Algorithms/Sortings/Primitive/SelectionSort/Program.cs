int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next() % 100;
}

Console.WriteLine("Array before selectionSort: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    int min = i;
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[j] < array[min])
        {
            min = j;
        }
    }
    (array[i], array[min]) = (array[min], array[i]);

}

Console.WriteLine("Array after selectionSort: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
