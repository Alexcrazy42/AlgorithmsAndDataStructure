int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next() % 100;
}

Console.WriteLine("Array before insertionSort: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();



int mid = 0;
while (array[mid] < array[mid+1])
{
    mid++;
}


for (int i = mid+1; i < array.Length; i++)
{
    int x = array[i];
    int j = i;
    while (j > 0 && array[j-1] > x)
    {
        array[j] = array[j-1];
        j--;
    }
    array[j] = x;
}

Console.WriteLine("Array after insertionSort: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
