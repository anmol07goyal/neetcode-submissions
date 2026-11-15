public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        int res = int.MaxValue;
        // if the array is rotated nums.Length times or 0
        if (nums[l] < nums[r])
            return nums[l];

        while (l <= r) {
            int mid = (l + r) / 2;
            if (nums[mid] > nums[r])
                l = mid + 1;
            else {
                r = mid - 1;
                res = Math.Min(res, nums[mid]);
            }
        }
        return res;
    }
}