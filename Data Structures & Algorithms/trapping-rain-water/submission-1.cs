public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        var prefix = new int[n];
        var suffix = new int[n];
        int max = 0;
        int res = 0;
        for (int i = 0; i < n; i++) {
            max = Math.Max(max, height[i]);
            prefix[i] = max;
        }
        max = 0;
        for (int i = n - 1; i >= 0; i--) {
            max = Math.Max(max, height[i]);
            suffix[i] = max;
        }

        for (int i = 0; i < n - 1; i++) 
            res += Math.Min(prefix[i], suffix[i]) - height[i];
        return res;
    }
}
