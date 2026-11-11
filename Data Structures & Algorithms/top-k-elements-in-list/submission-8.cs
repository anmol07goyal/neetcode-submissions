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

        for (int i = n - 1; i >= 0 && k > 0; i--) {
            while (bucket[i].Count > 0)
            {
                if (k <= 0) break;
                k--;
                res[k] = bucket[i][0];
                bucket[i].RemoveAt(0);
            }
        }

        return res;
    }
}