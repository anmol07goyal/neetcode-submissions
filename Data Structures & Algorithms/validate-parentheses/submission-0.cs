public class Solution {
    public bool IsValid(string s) {
        var open = new Stack<char>();
        foreach (char c in s) {
            if (c == '[' || c == '{' || c == '(')
                open.Push(c);
            else {
                char ch = open.Peek();
                if ((c == ']' && ch != '[') || (c == ')' && ch != '(') ||
                    (c == '}' && ch != '{'))
                    return false;
                open.Pop();
            }
        }
        return open.Count == 0;
    }
}