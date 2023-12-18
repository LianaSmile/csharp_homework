Console.Write("Type the number: ");
int last = Convert.ToInt32(Console.ReadLine());
int number = last / 2 + 1;

string line = "*";

while (number > 0)
{
    int i = number - 1;
    while (i > 0)
    {
        Console.Write(" ");
        i--;
    }
    Console.WriteLine(line);
    line += "**";
    number--;
}

int trunk = 3;

while (trunk > 0)
{
    int i = last / 2;
    while (i > 0)
    {
        Console.Write(" ");
        i--;
    }
    Console.WriteLine("*");
    trunk--;
}

