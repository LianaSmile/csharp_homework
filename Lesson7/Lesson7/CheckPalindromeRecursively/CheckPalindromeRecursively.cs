Console.Write("Enter the phrase: ");
string inputString = Console.ReadLine();

bool result = IsPalindromeRecursive(inputString.ToLower());
Console.WriteLine($"The string '{inputString}' is {(result ? "a palindrome" : "not a palindrome")}.");


static bool IsPalindromeRecursive(string s)
{
    if (s.Length <= 1)
    {
        return true;
    }

    if (s[0] == s[s.Length - 1])
    {
        return IsPalindromeRecursive(s.Substring(1, s.Length - 2));
    }
    else
    {
        return false;
    }
}

Console.ReadKey();
