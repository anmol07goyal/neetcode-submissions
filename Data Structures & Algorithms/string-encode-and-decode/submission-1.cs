public class Solution {
    public string Encode(IList<string> strs) {
        var res = new StringBuilder();
        foreach (var s in strs) 
            res.Append(s.Length).Append("#").Append(s);
        return res.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();
        int startIdx = 0;
        while (startIdx < s.Length) {
            var idx = s.IndexOf("#", startIdx);
            int len = int.Parse(s.Substring(startIdx, idx - startIdx));
            res.Add(s.Substring(idx + 1, len));
            startIdx = idx + len + 1;
        }
        return res;
    }
}
