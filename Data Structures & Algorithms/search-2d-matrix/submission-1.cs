public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        // for (int i = 0; i < matrix.Length; i++) {
        //     int left = 0;
        //     int right = matrix[i].Length - 1;
        //     while (left <= right) {
        //         int mid = left + (right - left) / 2;
        //         if (matrix[i][mid] == target) return true;
        //         else if (matrix[i][mid] < target) left = mid + 1;
        //         else right = mid - 1;
        //     }
        // }
        // return false;

        int rows = matrix.Length;       // 3
        int cols = matrix[0].Length;    // 4
        int left = 0;                   // idx 0  → matrix[0][0]
        int right = rows * cols - 1;    // idx 11 → matrix[2][3] tail of the matrix

        while(left <= right){
            int mid = left + (right - left) / 2;
            int midVal = matrix[mid / cols][mid % cols];

            if(midVal == target){
                return true;
            } else if(midVal < target){
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return false;

    }
}
