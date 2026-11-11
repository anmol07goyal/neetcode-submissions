public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        var operand = new Dictionary<string, Func<int, int, int>> {
            ["+"] = (a, b) => (a + b),
            ["-"] = (a, b) => (a - b),
            ["*"] = (a, b) => (a * b),
            ["/"] = (a, b) => (a / b),
        };

        foreach (var s in tokens) {
            if (int.TryParse(s, out int n))
                stack.Push(n);
            else {
                int n1 = 0;
                int n2 = 0;
                if (stack.Count > 0)
                    n1 = stack.Pop();
                if (stack.Count > 0)
                    n2 = stack.Pop();
                stack.Push(operand[s](n2, n1));
            }
        }
        return stack.Count > 0 ? stack.Pop() : 0;
    }
}
