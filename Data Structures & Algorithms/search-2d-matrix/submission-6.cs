public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int l = 0;
        int r = rows * cols - 1;
        
        while (l <= r) {
            int mid = (l+r)/2;
            int mr = mid / cols;
            int mc = mid % cols;
            if (target > matrix[mr][mc])
                l = mid + 1;
            else if (target < matrix[mr][mc])
                r = mid - 1;
            else
                return true;
        }
        
        return false;
    }
}