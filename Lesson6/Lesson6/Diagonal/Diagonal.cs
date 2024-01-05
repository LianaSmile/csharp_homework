List<List<int>> matrix = new List<List<int>>();

matrix.Add(new List<int>() { 1, 2, 3 });
matrix.Add(new List<int>() { 4, 5, 6 });
matrix.Add(new List<int>() { 7, 8, 9 });


List<int> result = Diagonal(matrix);

foreach (int item in result)
{
    Console.WriteLine(item);
}

List<int> Diagonal(List<List<int>> matrix)
{
    List<int> dioganal = new List<int>();
    int n = matrix.Count();
    for (int i = 0; i < matrix.Count(); i++)
    {
        dioganal.Add(matrix[i][n - i - 1]);
    }

    return dioganal;
}

Console.ReadKey();