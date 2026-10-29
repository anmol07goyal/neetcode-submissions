public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        if (nums.Length == 2) return [0,1];
        Dictionary<int, int> hash = new();

        for(int i = 0; i < nums.Length; i++)
        {
            hash[nums[i]] = i;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            int t = target - nums[i];
            if (hash.ContainsKey(t) && hash[t] != i)
                return [i, hash[t]];
        }

        return [0,1];
    }
}
