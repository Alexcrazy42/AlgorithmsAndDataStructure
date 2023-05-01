

int[] list = new int[4] { 2, 7, 11, 15 };

int target = 9;

int left = 0;
int right = list.Length - 1;

while (left < right)
{
    int sum = list[left] + list[right];
    if (sum == target)
    {
        Console.WriteLine($"indices of elements giving in summing target: {left}, {right} ");
        break;
    }
    if (sum > target)
    {
        right--;
    }
    if (sum < target)
    {
        left++;
    }
}
