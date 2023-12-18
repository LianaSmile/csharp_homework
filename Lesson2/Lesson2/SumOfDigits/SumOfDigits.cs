for (int i = 10; i < 100; i++)
{
    int main = i / 10;
    int remainder = i % 10;

    if (main + remainder > 14)
    {
        Console.WriteLine(i);
    }
}
