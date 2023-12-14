Console.CursorVisible = false;
Console.WriteLine("Task in progress...");
Console.BackgroundColor = ConsoleColor.White;

for (int i = 0; i < 20; i++)
{
    Console.Write(" ");
    Thread.Sleep(200);
}


Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("\nFinished!");