Console.Write("Enter the phase: ");
string phrase = Console.ReadLine().Trim();

if (phrase.Length == 0)
{
    Console.WriteLine("Empty line!");
    return;
}

string final_phrase = "";

foreach (char c in phrase)
{
    if (Char.IsLetter(c) || Char.IsDigit(c))
    {
        final_phrase += Char.ToLower(c);
    }
}

bool isPalidrome = true;

for (int i = 0; i < final_phrase.Length / 2; i++)
{
    if (final_phrase[i] != final_phrase[final_phrase.Length - 1 - i])
    {
        isPalidrome = false;
        break;
    }
}

Console.WriteLine(isPalidrome ? "palindrome" : "not palindrome");