public class MinStack {
    private Stack<int> stack;
    private int min;
    public MinStack() {
        stack = new();
        min = int.MaxValue;
    }

    public void Push(int val) {
        if (stack.Count == 0) {
            stack.Push(0);
            min = val;
        } else {
            stack.Push(val - min);
            min = Math.Min(min, val);
        }
    }

    public void Pop() {
        var pop = stack.Pop();
        if (pop < 0)
            min -= pop;
    }

    public int Top() {
        var top = stack.Peek();
        return top > 0 ? min + top : min;
    }

    public int GetMin() {
        return min;
    }
}
