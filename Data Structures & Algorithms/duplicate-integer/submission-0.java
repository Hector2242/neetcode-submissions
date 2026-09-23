class Solution {
    public boolean hasDuplicate(int[] nums) {
        Set<Integer> uni = new HashSet();

        for (int c : nums) {
            if (uni.contains(c)) {
                return true; // duplicate found
            } 
            uni.add(c);
        }

        return false;

    }
}