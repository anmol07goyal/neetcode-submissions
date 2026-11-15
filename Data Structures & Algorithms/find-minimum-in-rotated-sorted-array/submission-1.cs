public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        while (true) {
            if (nums[l] > nums[r])
                l++;
            else
                break;
        }
        return nums[l];
    }
}