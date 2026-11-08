public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length == 1)
            return true;

        int l = 0; 
        int r = s.Length - 1;
        while(l < r)
        {
            if (!char.IsLetterOrDigit(s[l]))
                l++;
            if (!char.IsLetterOrDigit(s[r]))
                r--;
            if (char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;
            l++;
            r--;
        }
        return true;
    }
}
