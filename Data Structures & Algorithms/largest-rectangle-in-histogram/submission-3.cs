public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = int.MinValue;
        var stack = new Stack<int[]>();  // this stores index & height
        int n = heights.Length;

        for (int i = 0; i < n; i++) {
            int start = i;
            while (stack.Count > 0 && stack.Peek()[1] > heights[i]) {
                var pair = stack.Pop();
                maxArea = Math.Max(maxArea, pair[1] * (i - pair[0]));
                start = pair[0];
            }
            stack.Push([start, heights[i]]);
        }

        while (stack.Count > 0)
        {
            var pair = stack.Pop();
            maxArea = Math.Max(maxArea, pair[1] * (n - pair[0]));
        }

        return maxArea;
    }
}