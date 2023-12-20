string text = "It        works      on my machine".Trim();
int count = 1;
string word = "";

if(text.Length == 0)
{
    Console.WriteLine("Empty stirng!");
    return;
}

foreach(char c in text)
{
    if (c != ' ')
    {
        word += c;
    }
    else if (c == ' ' && word.Length > 0) { 
        count++;
        word = "";
    }
}

Console.WriteLine(count);