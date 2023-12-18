int number = 1;
int square;

while (true)
{
    square = number * number;
    if (square > 1000)
    {
        break;
    }   
    Console.WriteLine(square);
    number++;
}
