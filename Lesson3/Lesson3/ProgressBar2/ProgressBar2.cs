string str;
str = " ";

Console.CursorVisible = false;
Console.WriteLine("Task in progress...");


for (int i = 1; i < 21; i++)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.Write(str.PadRight(i + 2));
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Write(str.PadLeft(21 - i));
    Console.Write((i * 5) + "%");
    Thread.Sleep(200);
    Console.Write("\r");
}

Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("\nFinished");


Console.ReadKey();

