// more than 135000

while (true)
{
    Console.Write("Type the number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    double leftSide = 1;
    double sign = -1;
    double start = 3;

    while (number > 0)
    {
        leftSide += (sign * (1 / start));
        sign *= -1;
        start += 2;
        number--;
    }

    double result = 4 * leftSide;

    Console.WriteLine(result);
    Console.WriteLine(Math.PI);

    int cont = Convert.ToInt32(Console.ReadLine());
    if (cont == 0)
    {
        break;
    }
}


