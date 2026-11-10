public class Solution {
    public bool IsAnagram(string s, string t) {
        var freq = new int[26];
        foreach (var c in s)
            freq[c - 'a']++;
        
        foreach (var c in t)
            freq[c - 'a']--;
        
        for (int i = 0; i < 26; i++)
            if (freq[i] != 0)
                return false;
        return true;
    }
}
