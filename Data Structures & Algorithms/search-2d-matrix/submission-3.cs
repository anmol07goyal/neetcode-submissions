public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int reqRow = 0;
        // first identify the row
        // then the col
        int top = 0;
        int bot = rows - 1;
        while (top <= bot) {
            reqRow = (top + bot) / 2;
            if (matrix[reqRow][cols - 1] < target)
                top = reqRow + 1;
            else if (matrix[reqRow][0] > target) {
                bot = reqRow - 1;
            } else
                break;
        }

        if (top > bot)
            return false;

        int l = 0;
        int r = cols - 1;
        while (l <= r) {
            int mid = (l + r) / 2;
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