public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var sq = new Dictionary<string, HashSet<char>>();

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char ch = board[r][c];
                string key = $"{r/3},{c/3}";
                if (ch == '.') continue;
                if ((rows.ContainsKey(r) && rows[r].Contains(ch)) ||
                    (cols.ContainsKey(c) && cols[c].Contains(ch)) ||
                    (sq.ContainsKey(key) && sq[key].Contains(ch)))
                    return false;
                
                if (!rows.ContainsKey(r)) rows[r] = new();
                if (!cols.ContainsKey(c)) cols[c] = new();
                if (!sq.ContainsKey(key)) sq[key] = new();
                rows[r].Add(ch);
                cols[c].Add(ch);
                sq[key].Add(ch);
            }
        }

        return true;
    }
}
