class Solution {
    public int[] twoSum(int[] nums, int target) {
        
        HashMap<Integer,Integer> freq = new HashMap();

        int current;
        int compliment; 

        for(int i = 0; i < nums.length; i++){
            current = nums[i];
            compliment = target - current;

            if(freq.containsKey(compliment)){
                return new int[] {freq.get(compliment), i};
            }

            freq.put(current,i);
        }

        return new int[] {};

    }
}
