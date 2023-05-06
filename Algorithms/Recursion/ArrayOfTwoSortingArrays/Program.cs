int[] firstArray = new int[] { 23, 35, 81, 95};
int[] secondArray = new int[] { 7, 14, 39, 55, 62, 74};
int[] resultArray = new int[firstArray.Length + secondArray.Length];

int[] firstArray1 = new int[] { 23, 35, 81, 95 };
int[] secondArray1 = new int[] { 7, 14, 39, 55, 62, 74 };
int[] resultArray1 = new int[firstArray1.Length + secondArray1.Length];
int length = firstArray1.Length + secondArray1.Length;

MergeSortByBruteForce(firstArray, secondArray, resultArray);
DisplayArray(resultArray);
Console.WriteLine();

int[] workSpace = new int[length];
MergeSortByRecursion(workSpace, 0, length - 1);
DisplayArray(resultArray1);

// not recursion solition
void MergeSortByBruteForce(int[] arrayA, int[] arrayB, int[] resultArray)
{
    int a = 0, b = 0, c = 0;

    while (a < arrayA.Length && b < arrayB.Length)
    {
        if (arrayA[a] < arrayB[b])
        {
            resultArray[c++] = arrayA[a++];
        }
        else
        {
            resultArray[c++] = arrayB[b++];
        }
    }

    while (a < arrayA.Length)
    {
        resultArray[c++] = arrayA[a++];
    }

    while (b < arrayB.Length)
    {
        resultArray[c++] = arrayB[b++];
    }
}


// recursion solution
void MergeSortByRecursion(int[] workSpace, int lowerBound, int upperBound)
{
    if (lowerBound == upperBound)
    {
        return;
    }
    else
    {
        int mid = (lowerBound + upperBound) / 2;
        MergeSortByRecursion(workSpace, lowerBound, mid);
        MergeSortByRecursion(workSpace, mid+1, upperBound);
        Merge(workSpace, lowerBound, mid + 1, upperBound);
    }
}

void Merge(int[] workSpace, int lowPtr, int highPtr, int upperBound)
{
    int j = 0; 
    int lowerBound = lowPtr;
    int mid = highPtr - 1;
    int n = upperBound - lowerBound + 1; 

    while (lowPtr <= mid && highPtr <= upperBound)
    {
        if (resultArray1[lowPtr] < resultArray1[highPtr])
        {
            workSpace[j++] = resultArray1[lowPtr++];
        }
        else
        {
            workSpace[j++] = resultArray1[highPtr++];
        }
    }

    while (lowPtr <= mid)
    {
        workSpace[j++] = resultArray1[lowPtr++];
    }

    while (highPtr <= upperBound)
    {
        workSpace[j++] = resultArray1[highPtr++];
    }

    for (j = 0; j < n; j++)
    {
        resultArray1[lowerBound + j] = workSpace[j]; 
    }
}


void DisplayArray(int[] array)
{
    
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
}
