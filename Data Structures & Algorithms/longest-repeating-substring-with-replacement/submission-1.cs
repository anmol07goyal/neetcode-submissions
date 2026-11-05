public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> freq = new();
        int res = 0;
        int l = 0;

        for (int r = 0; r < s.Length; r++) {
            freq[s[r]] = freq.GetValueOrDefault(s[r], 0) + 1;

            while (r - l + 1 - GetMaxFreq(freq) > k) {
                freq[s[l]] -= 1;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }

    public int GetMaxFreq(Dictionary<char, int> freq) {
        int max = 0;
        foreach (var val in freq.Values) 
            max = Math.Max(max, val);
        return max;
    }
}