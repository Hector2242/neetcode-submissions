class Solution {
    public boolean hasDuplicate(int[] nums) {

        HashSet<Integer> hasDuplicate = new HashSet();

        if(nums.length == 0){
				return false;
		}

        for(int n : nums){
            if(hasDuplicate.contains(n)){
                return true;
            }
            hasDuplicate.add(n);
        }

        return false;

    }
}