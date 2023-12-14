﻿Console.Write("Type the month number: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Type the year: ");
int year = Convert.ToInt32(Console.ReadLine());

if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
{
    Console.WriteLine(31);
}
else if (month == 4 || month == 6 || month == 9 || month == 11)
{
    Console.WriteLine(30);
}
else if (month == 2)
{
    if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    {
        Console.WriteLine(29);
    }
    else
    {
        Console.WriteLine(28);
    }
}
else
{
    Console.WriteLine("Invalid month.");
}
