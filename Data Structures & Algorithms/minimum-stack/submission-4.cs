public class MinStack {
    private Stack<long> stack;
    private long min;

    public MinStack() {
        stack = new();
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
        return top > 0 ? (int)(min + top) : (int)min;
    }

    public int GetMin() {
        return (int)min;
    }
}
