public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int reqRow = -1;
        // first identify the row
        // then the col
        int l = 0;
        int r = rows - 1;
        while (l <= r) {
            int mid = l == r ? l : (l + r) / 2;
            if (matrix[mid][cols - 1] == target)
                return true;
            else if (matrix[mid][cols - 1] > target) {
                if (matrix[mid][0] == target)
                    return true;
                else if (matrix[mid][0] < target) {
                    reqRow = mid;
                    break;
                } else
                    r = mid - 1;
            } else
                l = mid + 1;
        }

        if (reqRow == -1)
            return false;

        l = 0;
        r = cols - 1;
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