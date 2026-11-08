public class Solution {
    public string MinWindow(string s, string t) {
        int sCount = s.Length;
        int tCount = t.Length;

        if (sCount < tCount)
            return "";
        if (sCount == 1 && tCount == 1 && s == t)
            return s;

        string res = "";
        var need = new Dictionary<char, int>();
        var have = new Dictionary<char, int>();
        int needKeys = 0;
        int haveKeys = 0;
        foreach (char c in t) {
            need[c] = need.GetValueOrDefault(c, 0) + 1;
            have[c] = 0;
        }

        foreach (var n in need.Keys) needKeys++;

        for (int l = 0; l < sCount; l++) {
            if (!need.ContainsKey(s[l]))
                continue;

            // reset have dict and haveKeys
            foreach (var key in have.Keys)
                have[key] = 0;
            haveKeys = 0;

            for (int r = l; r < sCount; r++) {
                if (have.ContainsKey(s[r])) {
                    have[s[r]]++;
                    // foreach(var c in have)
                    //     Console.WriteLine("have: " + c);
                    if (have[s[r]] == need[s[r]])
                        haveKeys++;
                    if (needKeys == haveKeys) {
                        if (res.Length == 0)
                            res = s.Substring(l, r - l + 1);
                        else if (res.Length > r - l + 1)
                            res = s.Substring(l, r - l + 1);

                        break;
                    }
                }
                // Console.WriteLine("res: " + res);
            }
        }
        return res;
    }
}
