Console.Write("Type the number: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number != 1)
{
    if(number % 2 == 0)
    {
        number /= 2;
    }
    else
    {
        number = number * 3 + 1;
    }
    Console.WriteLine(number);
}