var a1 = new[] { 1, 5, 10, 8 };
var a2 = new[] { 6, 8, 17, 4, 1 };

for (int i = 0; i < a1.Length; i++)
{
    for (int j = 0; j < a2.Length; j++)
    {
        if (a1[i] == a2[j])
        {
            Console.Write(a2[j] + ", ");
        }
    }
}
Thread.Sleep(1);
Console.Write("\b\b");

