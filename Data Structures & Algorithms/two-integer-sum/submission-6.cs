public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) 
            seen[nums[i]] = i;
        
        for (int i = 0; i < nums.Length; i++) {
            var other = target - nums[i];
            if (seen.ContainsKey(other) && i != seen[other])
                return [i, seen[other]];
        }

        return new int[2];
    }
}
