public class Solution {
    public string MinWindow(string s, string t) {
        int sCount = s.Length;
        int tCount = t.Length;

        if (sCount < tCount)
            return "";
        if (sCount == 1 && tCount == 1 && s == t)
            return s;

        var need = new Dictionary<char, int>();
        var have = new Dictionary<char, int>();
        int needKeys = 0;
        int haveKeys = 0;
        int r = 0;
        int minLen = int.MaxValue;
        int startIdx = -1;
        foreach (char c in t) {
            need[c] = need.GetValueOrDefault(c, 0) + 1;
            have[c] = 0;
        }

        needKeys = need.Count;

        for (int l = 0; l < sCount; l++) {
            if (!need.ContainsKey(s[l]))
                continue;

            // reset have dict and haveKeys
            // foreach (var key in have.Keys)
            //     have[key] = 0;
            // haveKeys = 0;

            while (r < sCount) {
                if (have.ContainsKey(s[r])) {
                    have[s[r]]++;
                    if (have[s[r]] == need[s[r]])
                        haveKeys++;
                    if (needKeys == haveKeys) {
                        int curLen = r - l + 1;
                        if (curLen < minLen) {
                            minLen = curLen;
                            startIdx = l;
                        }

                        have[s[l]]--;
                        if (have[s[l]] < need[s[l]])
                            haveKeys--;
                        r++;
                        break;
                    }
                }
                r++;
            }
            if (r >= sCount)
                r = sCount - 1;
        }
        return minLen == int.MaxValue ? "" : s.Substring(startIdx, minLen);
    }
}
