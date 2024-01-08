public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            if (!IsValid(board, row, 0, row, 8))
            {
                return false;
            }
        }

        for (int col = 0; col < 9; col++)
        {
            if (!IsValid(board, 0, col, 8, col))
            {
                return false;
            }
        }

        for (int row = 0; row < 9; row += 3)
        {
            for (int col = 0; col < 9; col += 3)
            {
                if (!IsValid(board, row, col, row + 2, col + 2))
                {
                    return false;
                }
            }
        }

        return true;
    }

    private bool IsValid(char[][] board, int startRow, int startCol, int endRow, int endCol)
    {
        bool[] used = new bool[10];

        for (int row = startRow; row <= endRow; row++)
        {
            for (int col = startCol; col <= endCol; col++)
            {
                char current = board[row][col];

                if (current != '.')
                {
                    int digit = current - '0';

                    if (used[digit])
                    {
                        return false; 
                    }

                    used[digit] = true;
                }
            }
        }

        return true;
    }
}
