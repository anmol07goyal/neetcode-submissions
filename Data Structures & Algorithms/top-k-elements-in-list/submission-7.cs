public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        var res = new int[k];
        foreach (var n in nums) 
            freqMap[n] = freqMap.GetValueOrDefault(n, 0) + 1;
        while (k > 0)
        {
            k--;
            int max = 0;
            int maxKey = 0;
            foreach (var num in freqMap)
            {
                max = Math.Max(num.Value, max);
                if (max == num.Value)
                    maxKey = num.Key;
            }

            freqMap.Remove(maxKey);
            res[k] = maxKey;
        }
        return res;    
    }
}