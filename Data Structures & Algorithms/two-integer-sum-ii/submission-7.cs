public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] result = new int[2];

        int left = 0;
        int right = nums.Length-1;

        while (left < right) {
            int sum = nums[left] + nums[right];

            if (sum == target){
                return new int[] { left + 1, right + 1 };
            } else if (sum > target) {
                right--;
            } else {
                left++;
            }
        }

        return null;
        // for(int i = 0; i < nums.Length; i++){
        //     for(int j = i+1; j < nums.Length; j++){
        //         if((nums[i] + nums[j]) == target){
        //                 result[0] = i+1;
        //                 result[1] = j+1;
        //         }
        //     }

        // }

        // return result;
        
    }
}
