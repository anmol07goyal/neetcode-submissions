public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> freq = new();
        foreach (var s in strs)
        {
            int[] count = new int[26];
            foreach(char c in s)
                count[c-'a']++;
            var key = string.Join(",", count);
            if (!freq.ContainsKey(key))
                freq[key] = new List<string>();
            freq[key].Add(s);
        }
        return freq.Values.ToList<List<string>>();
    }
}
