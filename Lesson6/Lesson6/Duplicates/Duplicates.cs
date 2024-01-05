List<int> RemoveDuplicates(List<int> list)
{
    List<int> newArray = new List<int>();

    foreach (int i in list)
    {
        if (!newArray.Contains(i))
        {
            newArray.Add(i);
        }
    }

    return newArray;
}


List<int> testList = new List<int> { 1, 2, 1, 5, 5, 7 };

List<int> result = RemoveDuplicates(testList);

foreach (int item in result)
{
    Console.WriteLine(item);
}

Console.ReadKey();