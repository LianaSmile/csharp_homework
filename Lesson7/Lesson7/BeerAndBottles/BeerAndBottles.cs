int BeerAndBottles(int n, int amount = 0)
{
    if (n < 3)
    {
        return amount;
    }

    amount += n / 3;

    return BeerAndBottles(n % 3 + n / 3, amount);
}


Console.WriteLine(BeerAndBottles(15));