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

        foreach(var i in freq)
        {
            if (bucket[i.Value - 1] == null)
                bucket[i.Value - 1] = new List<int>();
            bucket[i.Value - 1].Add(i.Key);
        }

        int index = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            if (bucket[i] != null && bucket[i].Count > 0 && index < k)    
            {
                foreach(var num in bucket[i])   
                    res[index++] = num;
            }
        }
        
        return res;
    }
}
