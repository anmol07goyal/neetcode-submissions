public class Solution {
    public string MinWindow(string s, string t) {
        int sCount = s.Length;
        int tCount = t.Length;

        if (sCount < tCount || tCount == 0)
            return "";

        string res = "";
        var need = new Dictionary<char, int>();
        var have = new Dictionary<char, int>();
        int needKeys = 0;
        int haveKeys = 0;
        int l = 0;
        int startIdx = -1;
        int minLen = int.MaxValue;
        foreach (char c in t) {
            need[c] = need.GetValueOrDefault(c, 0) + 1;
            have[c] = 0;
        }

        needKeys = need.Count;

        for (int r = 0; r < sCount; r++) {
            char c = s[r];
            if (!have.ContainsKey(c))
                continue;
            have[c]++;
            if (have[c] == need[c])
                haveKeys++;
            while (haveKeys == needKeys) {
                int curLen = r - l + 1;
                if (curLen < minLen) {
                    minLen = curLen;
                    startIdx = l;
                }

                char leftChar = s[l];
                if (have.ContainsKey(leftChar)) {
                    have[leftChar]--;
                    if (have[leftChar] < need[leftChar])
                        haveKeys--;
                }
                l++;
            }
        }

        return minLen == int.MaxValue ? "" : s.Substring(startIdx, minLen);
    }
}