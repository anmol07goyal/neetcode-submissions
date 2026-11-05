public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> freq = new();
        int res = 0;
        int l = 0;
        int maxFreq = 0;

        for (int r = 0; r < s.Length; r++) {
            freq[s[r]] = freq.GetValueOrDefault(s[r], 0) + 1;
            maxFreq = Math.Max(maxFreq, freq[s[r]]);
            while (r - l + 1 - maxFreq > k) {
                freq[s[l]] -= 1;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}