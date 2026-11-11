public class Solution {
    public int[] DailyTemperatures(int[] temp) {
        Stack<int> stack = new();  // 1, 2,
        int len = temp.Length;
        int[] res = new int[len];
        res[len - 1] = 0;
        stack.Push(0);

        for (int i = 1; i < len; i++) {
            while (stack.Count > 0 && temp[i] > temp[stack.Peek()]) {
                int pop = stack.Pop();
                res[pop] = i - pop;
            }
            stack.Push(i);
        }
        return res;
    }
}
