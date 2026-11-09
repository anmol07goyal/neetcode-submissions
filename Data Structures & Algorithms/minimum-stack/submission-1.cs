public class MinStack {
    private List<int> stack = new();
    private List<int> minStack = new();
    
    public MinStack() {
        stack = new();
        minStack = new();
    }
    
    public void Push(int val) {
        stack.Add(val);
        if (minStack.Count == 0)
            minStack.Add(val);
        else
            minStack.Add(Math.Min(minStack[minStack.Count - 1], val));
    }
    
    public void Pop() {
        stack.RemoveAt(stack.Count - 1);
        minStack.RemoveAt(minStack.Count - 1);
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return minStack[minStack.Count - 1];
    }
}
