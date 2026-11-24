public class Solution {
    public bool IsPalindrome(string s) {
        int n = s.Length;
        if (n == 1) 
            return true;
        
        int l = 0;
        int r = n-1;
        while (l < r) {
            while (!IsAlphaNum(s[l]))
                l++;
            while (!IsAlphaNum(s[r]))
                r--;
            if (char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;
            l++;
            r--;
        }
        return true;
    }

    public bool IsAlphaNum(char c) {
        return ((c >= 'a' && c <= 'z') || 
                (c >= 'A' && c <= 'Z') || 
                (c >= '0' && c <= '9'));
    }
}
