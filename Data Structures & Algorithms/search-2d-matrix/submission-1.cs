public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int reqRow = -1;
        // first identify the row
        // then the col

        for (int i = 0; i < rows; i++) {
            if (target <= matrix[i][cols - 1]) {
                reqRow = i;
                break;
            }
        }

        if (reqRow == -1)
            return false;

        int l = 0;
        int r = cols - 1;
        while (l <= r)
        {
            int mid = (l+r)/2;
            if (matrix[reqRow][mid] < target)
                l = mid + 1;
            else if (matrix[reqRow][mid] > target)
                r = mid - 1;
            else
                return true;
        }

        return false;
    }
}