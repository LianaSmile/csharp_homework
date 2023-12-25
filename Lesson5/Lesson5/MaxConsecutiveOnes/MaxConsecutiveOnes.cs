int FindMaxConsecutiveOnes(int[] nums)
{
    int count = 0;
    int max = 0;
    foreach (int x in nums)
    {
        if (x == 1)
        {
            count++;
            max = Math.Max(max, count);
        }
        else
        {
            count = 0;
        }
    }
    return max;
}
