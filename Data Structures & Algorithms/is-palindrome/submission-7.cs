public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 1)
            return true;

        int l = 0; 
        int r = s.Length - 1;
        
        while(l < r)
        {
            if (!IsAlphaNum(s[l]))
            {
                l++;
                continue;
            }
            if (!IsAlphaNum(s[r]))
            {
                r--;
                continue;
            }
            if (char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;
            l++;
            r--;
        }
        return true;
    }

    public bool IsAlphaNum(char c)
    {
        return (c >= 'A' && c <= 'Z' ||
                c >= 'a' && c <= 'z' ||
                c >= '0' && c <= '9');
    }
}
