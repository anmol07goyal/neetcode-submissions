public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new();
        Array.Sort(nums);
        //-4,-1,-1,0,1,2
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i - 1] == nums[i])
                continue;
            int l = i + 1;
            int r = nums.Length - 1;
            while (l < r)
            {
                if ((r < nums.Length - 1 && nums[r] == nums[r + 1]) ||
                    nums[l] + nums[r] > -nums[i])
                {
                    r--;
                    continue;
                }
                else if ((l > 0 && nums[l] == nums[l - 1]) ||
                        nums[l] + nums[r] < -nums[i])
                {
                    l++;
                    continue;
                }
                else
                {                    
                    res.Add(new List<int>{nums[i], nums[l], nums[r]});
                    l++;
                    r--;
                }
            }
        }
        return res;
    }
}
