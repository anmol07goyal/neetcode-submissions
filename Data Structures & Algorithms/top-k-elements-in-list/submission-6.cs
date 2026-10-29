public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new();
        int n = nums.Length;
        var res = new int[k];
        foreach(var i in nums)
        {
            if (!freq.ContainsKey(i)) freq[i] = 1;
            else freq[i]++;
        }
       
        var bucket = new List<int>[n];
        for (int i = 0; i < n; i++)
            bucket[i] = new List<int>();

        foreach(var i in freq)
            bucket[i.Value - 1].Add(i.Key);

        int index = 0;

        for (int i = n - 1; i >= 0 && index < k; i--)
        {
            foreach(var num in bucket[i])   
                res[index++] = num;
        }
        
        return res;
    }
}
