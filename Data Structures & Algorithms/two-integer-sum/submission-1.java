class Solution {
    public int[] twoSum(int[] nums, int target) {

        HashMap<Integer,Integer> sum = new HashMap();


        for(int i = 0; i < nums.length; i++){
	        int compliment = target - nums[i];
	        if(sum.containsKey(compliment)){
		        return new int[]{sum.get(compliment), i};
	        }
		        sum.put(nums[i], i);
        }
        
		return null;
    }
}