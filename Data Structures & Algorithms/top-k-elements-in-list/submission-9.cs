public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        int n = nums.Length;
        var res = new int[k];
        foreach (var i in nums) 
            freqMap[i] = freqMap.GetValueOrDefault(i, 0) + 1;

        var bucket = new List<int>[n];
        for (int i = 0; i < n; i++) 
            bucket[i] = new List<int>();

        foreach (var f in freqMap) 
            bucket[f.Value - 1].Add(f.Key);

        int index = 0;
        for (int i = n - 1; i >= 0 && index < k; i--) {
            foreach (var num in bucket[i])
                res[index++] = num;
        }

        return res;
    }
}