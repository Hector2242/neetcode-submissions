public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();
        int longest = 0;

        foreach (int n in nums) {
            numSet.Add(n);
        }

        foreach (int x in numSet) {
            // x - 1 in the set means x is in the middle of a run
            if (numSet.Contains(x - 1)) {
                continue;
            }

            // x starts a run: count up while the next number exists
            int length = 1;
            while (numSet.Contains(x + length)) {
                length++;
            }

            longest = Math.Max(longest, length);
        }

        return longest;
    }
}