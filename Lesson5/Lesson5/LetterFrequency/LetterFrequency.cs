using System.Text;

string symbols = " ՜՞՛`,.:-_i—0123456789()«»ю*\";–…՝";

string path = @"C:\Users\Admin\Desktop\C#\Homework\Lesson5\Lesson5\LetterFrequency\ՐԱՖՖԻ-ՍԱՄՎԵԼ.txt";

string[] lines = File.ReadAllLines(path, Encoding.UTF8);

Console.OutputEncoding = Encoding.UTF8;

Dictionary<char, int> armenianDictionary = new Dictionary<char, int>();

int allLetters = 0;

for (int i = 0; i < lines.Length; i++)
{
    string line = lines[i];
    line = line.ToLower().Replace("ու", "x").Replace("h", "հ").Replace("եւ", "և");

    for (int j = 0; j < symbols.Length; j++)
    {
        char symbol = symbols[j];
        line = line.Replace(symbol.ToString(), "");
    }

    line = line.ToLower().Replace("ու", "x").Replace("xւ", "x");

    foreach (char c in line)
    {
        if (Char.IsLetter(c))
        {
            if (armenianDictionary.ContainsKey(c))
            {
                armenianDictionary[c] += 1;
            }
            else
            {
                armenianDictionary[c] = 1;
            }
        }
        allLetters++;
    }
}

var sortedLetters = armenianDictionary.OrderByDescending(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);

foreach (var kvp in sortedLetters)
{
    double percentage = (kvp.Value / (double)allLetters) * 100;

    if (kvp.Key == 'x')
    {
        Console.WriteLine($"ու: {Math.Round(percentage, 4)} %");
    }
    else
    {
        Console.WriteLine($"{kvp.Key}: {Math.Round(percentage, 4)} %");
    }
}

Console.ReadKey();  

