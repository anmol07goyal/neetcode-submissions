public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] freq = new int[26];

        if (s.Length != t.Length)
            return false;
        
        foreach(char c in s)
            freq[c - 'a']++;
        foreach(char c in t)
            freq[c - 'a']--;

        for (int i = 0; i < 26; i++)
        {
            if (freq[i] != 0)
                return false;
        }
        return true;
    }
}
