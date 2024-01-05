public IList<int> LuckyNumbers(int[][] matrix)
{
    List<int> LuckyNumbersArray = new List<int>();

    for (int i = 0; i < matrix.Length; i++)
    {
        int minInRow = FindMinInRow(matrix, i);
        int maxInCol = FindMaxInColumn(matrix, minInRow);

        if (matrix[i][minInRow] == matrix[maxInCol][minInRow])
        {
            LuckyNumbersArray.Add(matrix[i][minInRow]);
        }
    }
    return LuckyNumbersArray;
}

private int FindMinInRow(int[][] matrix, int rowIndex)
{
    int minIndex = 0;
    for (int j = 1; j < matrix[0].Length; j++)
    {
        if (matrix[rowIndex][minIndex] > matrix[rowIndex][j])
        {
            minIndex = j;
        }
    }
    return minIndex;
}

private int FindMaxInColumn(int[][] matrix, int columnIndex)
{
    int maxIndex = 0;
    for (int k = 1; k < matrix.Length; k++)
    {
        if (matrix[maxIndex][columnIndex] < matrix[k][columnIndex])
        {
            maxIndex = k;
        }
    }
    return maxIndex;
}
