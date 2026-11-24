public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<string>();
        var operand = new Dictionary<string, Func<int, int, int>> {
            ["+"] = (a, b) => (a + b), 
            ["-"] = (a, b) => (a - b), 
            ["*"] = (a, b) => (a * b),
            ["/"] = (a, b) => (a / b),
        }
        // foreach (var s in tokens)
    }
}
