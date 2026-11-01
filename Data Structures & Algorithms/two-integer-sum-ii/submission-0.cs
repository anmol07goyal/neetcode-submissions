public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers.Length == 2)
            return new int[] {1, 2};
        
        int l = 0; 
        int r = numbers.Length - 1;
        while (l < r)
        {
            if (numbers[l] + numbers[r] > target)
            {
                r--;
                continue;
            }
            else if (numbers[l] + numbers[r] < target)
            {
                l++;
                continue;
            }
            else
                return new int[] {l + 1, r + 1};
        }
        return new int[2];
    }
}
