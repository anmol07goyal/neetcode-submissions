public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i - 1] == nums[i])
                continue;
            int l = i + 1;
            int r = nums.Length - 1;
            while (l < r)
            {
                int sum = nums[l] + nums[r] + nums[i];
                if (sum > 0)
                    r--;
                else if (sum < 0)
                    l++;
                else
                {                    
                    res.Add(new List<int>{nums[i], nums[l], nums[r]});
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1])
                        l++;
                }
            }
        }
        return res;
    }
}
