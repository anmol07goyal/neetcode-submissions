public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        while (l < r) {
            var res = nums[l] + nums[r];
            if (res > target)
                r--;
            else if (res < target)
                l++;
            else
                return [l + 1, r + 1];
        }
        return [1, 2];
    }
}
