public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        if (nums.Length == 2) return [0,1];
        Dictionary<int, int> hash = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int t = target - nums[i];
            if (hash.ContainsKey(t) && hash[t] != i)
                return [hash[t], i];
            else
                hash[nums[i]] = i;
        }

        return [0,1];
    }
}
