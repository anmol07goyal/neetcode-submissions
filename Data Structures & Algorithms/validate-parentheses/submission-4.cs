public class Solution {
    public bool IsValid(string s) {
        var open = new Stack<char>();
        var openCloseDict = new Dictionary<char, char>() {
            [']'] = '[',
            [')'] = '(',
            ['}'] = '{',
        };
        open.Push(s[0]);

        for (int i = 1; i < s.Length; i++) {
            if (openCloseDict.ContainsKey(s[i])) {
                if (open.Count > 0) {
                    if (open.Peek() == openCloseDict[s[i]]) {
                        open.Pop();
                        continue;
                    }
                }
            }
            open.Push(s[i]);
        }

        return open.Count == 0;
    }
}