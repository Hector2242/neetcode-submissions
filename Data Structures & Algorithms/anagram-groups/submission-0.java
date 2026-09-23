
class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        // Map from sorted/count key -> list of words
        Map<String, List<String>> res = new HashMap<>();

        for (String s : strs) {
            int[] count = new int[26]; // letter frequency for 'a' to 'z'

            for (char c : s.toCharArray()) {
                count[c - 'a']++; // increment letter count
            }

            // Convert count array to a unique string key
            String key = Arrays.toString(count);

            // Add the string to the map
            res.computeIfAbsent(key, k -> new ArrayList<>()).add(s);
        }

        return new ArrayList<>(res.values());
    }
}
