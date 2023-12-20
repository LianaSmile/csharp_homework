int[] numbers = [1, 3, 5, -1, -6];

for (int i = numbers.Length - 1; i >= 0; i--)
{
    if (numbers[i] > 0)
    {
        Console.WriteLine(numbers[i]);
        break;
    }
}