﻿Console.Write("Type the first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Type the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Type the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && a >= c)
{
    Console.WriteLine(a);
}
else if (b >= c)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(c);
}