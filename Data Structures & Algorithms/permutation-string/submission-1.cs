public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int l1 = s1.Length;
        int l2 = s2.Length;

        if (l1 > l2)
            return false;
        if (l1 == 1 && l2 == 1 && s1 == s2)
            return true;

        int[] freq = new int[26];
        bool found = true;

        foreach (var c in s1) 
            freq[c - 'a'] += 1;

        for (int l = 0; l <= l2 - l1; l++) {
            int r = l + l1 - 1;
            var freqDup = (int[])freq.Clone();

            for (int i = l; i <= r; i++) 
                freqDup[s2[i] - 'a'] -= 1;
            for (int i = 0; i < 26; i++) {
                if (freqDup[i] != 0) {
                    found = false;
                    break;
                } else
                    found = true;
            }
            if (found)
                return true;
        }
        return found;
    }
}
