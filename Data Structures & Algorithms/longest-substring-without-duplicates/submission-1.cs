public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        int n = s.Length;
        int l = 0;
        int res = 0;
        for (int i = 0; i < n; i++) {
            if (set.Contains(s[i])) {
                while (set.Contains(s[i])) {
                    set.Remove(s[l]);
                    l++;
                }
            }
            set.Add(s[i]);
            res = Math.Max(res, i - l + 1);
        }
        return res;
    }
}