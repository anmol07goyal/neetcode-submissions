public class MinStack {
    private Stack<int> stack = new();
    private Stack<int> minStack = new();
    
    public MinStack() {
        stack = new();
        minStack = new();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0)
            minStack.Push(val);
        else
            minStack.Push(Math.Min(minStack.Peek(), val));
    }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
