public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new();
        int n = nums.Length; //2
        var res = new int[k];
        foreach(var i in nums)
        {
            if (!freq.ContainsKey(i)) freq[i] = 1;
            else freq[i]++;
        }
       
        var bucket = new int[n];

        foreach(var i in freq)
            bucket[i.Value - 1] = i.Key;
        
        int j = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            if (bucket[i] > 0 && j < k)    
            {   
                res[j] = bucket[i];
                j++;
            }
        }
        
        return res;
    }
}
