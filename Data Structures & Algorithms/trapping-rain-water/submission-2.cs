public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int l = 0;
        int r = n - 1;
        int res = 0;
        int leftMax = height[0];
        int rightMax = height[n - 1];
        while (l < r) {
            if (leftMax < rightMax) {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                res += leftMax - height[l];
            }
            else {
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                res += rightMax - height[r];
            }
        }
        return res;
    }
}