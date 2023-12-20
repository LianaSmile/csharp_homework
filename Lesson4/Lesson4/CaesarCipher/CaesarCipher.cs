var text = "attackatonce";  // xqqxzhxqlkzb
var shift = 3;

for (int i = 0; i < text.Length; i++)
{
    char c = text[i];
    for (int j = 0; j < shift; j++)
    {
        c = (char)(c - 1);
        if (c < 'a')
        {
            c = 'z';
        }
    }

    Console.Write(c);
}