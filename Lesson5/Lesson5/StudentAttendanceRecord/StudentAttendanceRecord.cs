bool checkrecord(string s)
{
    int absent = 0;
    int late = 0;

    foreach (char c in s)
    {
        if (c == 'a')
        {
            absent++;
            late = 0;
            if (absent > 1)
                return false;
        }
        else if (c == 'l')
        {
            late++;
            if (late > 2)
                return false;
        }
        else
        {
            late = 0;
        }
    }
    return true;
}
