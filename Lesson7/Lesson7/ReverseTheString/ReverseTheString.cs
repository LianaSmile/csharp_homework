Console.Write("Enter the string to reverse: ");
string word = Console.ReadLine();

string reverseString = "";

for (int i = word.Count() - 1; i >= 0; i--)
{
    reverseString += word[i];
}

Console.WriteLine(reverseString);
Console.ReadKey();