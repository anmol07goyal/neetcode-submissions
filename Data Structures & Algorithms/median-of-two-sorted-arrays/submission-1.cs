public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // brute force
        int n1 = nums1.Length, n2 = nums2.Length;
        int[] nums = new int[n1 + n2];
        for (int i = 0; i < n1; i++) 
            nums[i] = nums1[i];
        for (int i = 0; i < n2; i++) 
            nums[i + n1] = nums2[i];
        Array.Sort(nums);
        
        int mid = (n1 + n2 - 1) / 2;
        if ((n1 + n2) % 2 == 0)
            return (double)(nums[mid] + nums[mid + 1]) / 2;
        else
            return nums[mid];
    }
}