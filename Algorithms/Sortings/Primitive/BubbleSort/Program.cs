int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next() % 100;
}

Console.WriteLine("Array before bubbleSort: ");
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();


for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - i - 1; j++)
    {
        if (array[j] > array[j+1])
        {
            (array[j], array[j+1]) = (array[j+1], array[j]);
        }
    }
}

Console.WriteLine("Array after bubbleSort: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
