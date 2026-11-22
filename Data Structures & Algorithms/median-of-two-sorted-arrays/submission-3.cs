public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // Always run binary search on the shorter array to keep time complexity O(log(min(m, n)))
        // and prevent the longer array's partition index from going out of bounds.
        int[] shortArr = nums1.Length <= nums2.Length ? nums1 : nums2;
        int[] longArr = nums1.Length > nums2.Length ? nums1 : nums2;

        int shortLen = shortArr.Length;
        int longLen = longArr.Length;
        int totalLen = shortLen + longLen;

        // Number of elements that belong in the left half of the combined sorted array
        int halfLen = totalLen / 2;

        // Binary search bounds represent the COUNT of elements we take from shortArr
        // Minimum possible count = 0 (take nothing from shortArr)
        // Maximum possible count = shortLen (take everything from shortArr)
        int minTakeFromShort = 0;
        int maxTakeFromShort = shortLen;

        while (minTakeFromShort <= maxTakeFromShort) {
            // 1. Choose how many elements to take from each array for the left half
            int takeFromShort = minTakeFromShort + (maxTakeFromShort - minTakeFromShort) / 2;
            int takeFromLong = halfLen - takeFromShort;

            // 2. Find the 4 boundary values right around the cut (partition)
            //    Left side ends at index (takeCount - 1). If takeCount is 0, there is no left
            //    element. Right side starts at index (takeCount).    If takeCount is Length, there
            //    is no right element.
            int shortLeftMax = (takeFromShort == 0) ? int.MinValue : shortArr[takeFromShort - 1];
            int shortRightMin =
                (takeFromShort == shortLen) ? int.MaxValue : shortArr[takeFromShort];

            int longLeftMax = (takeFromLong == 0) ? int.MinValue : longArr[takeFromLong - 1];
            int longRightMin = (takeFromLong == longLen) ? int.MaxValue : longArr[takeFromLong];

            // 3. Check if the partition is valid:
            //    Every number on the left side must be <= every number on the right side.
            //    (We already know shortLeftMax <= shortRightMin and longLeftMax <= longRightMin
            //     because the input arrays are sorted, so we only check the cross-pairs.)
            if (shortLeftMax <= longRightMin && longLeftMax <= shortRightMin) {
                // Valid partition found! Calculate the median:
                if (totalLen % 2 != 0) {
                    // Odd total length: because halfLen uses integer division (e.g., 5 / 2 = 2),
                    // the right half has 1 extra element. The smallest element on the right is the
                    // median.
                    return Math.Min(shortRightMin, longRightMin);
                } else {
                    // Even total length: median is the average of the largest element on the left
                    // and the smallest element on the right.
                    int maxOfLeftSide = Math.Max(shortLeftMax, longLeftMax);
                    int minOfRightSide = Math.Min(shortRightMin, longRightMin);
                    return (maxOfLeftSide + minOfRightSide) / 2.0;
                }
            }
            // 4. Adjust binary search range if the partition is invalid:
            else if (shortLeftMax > longRightMin) {
                // shortLeftMax is too big to be on the left side.
                // We took too many elements from shortArr -> search the left half (take fewer).
                maxTakeFromShort = takeFromShort - 1;
            } else {
                // longLeftMax > shortRightMin: shortRightMin is too small to be on the right side.
                // We took too few elements from shortArr -> search the right half (take more).
                minTakeFromShort = takeFromShort + 1;
            }
        }

        return 0.0;  // Unreachable for valid sorted inputs
    }
}
