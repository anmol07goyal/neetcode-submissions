public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        var output = new List<List<string>>();

        foreach (var s in strs) {
            int[] count = new int[26];
            foreach (var ch in s) 
                count[ch - 'a']++;
            string key = string.Join(",", count);
            if (!res.ContainsKey(key))
                res.Add(key, new List<string>());
            res[key].Add(s);
        }

        foreach(var val in res.Values)
            output.Add(val);
        return output;
    }
}