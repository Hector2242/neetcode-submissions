class Solution {
    public boolean isAnagram(String s, String t) {

        if(s.length() != t.length()){
            return false;
        }

        Map<Character,Integer> freqMap = new HashMap();

        for (char c : s.toCharArray()) {
            if (freqMap.containsKey(c)) {
                freqMap.put(c, freqMap.get(c) + 1);
            } else {
                freqMap.put(c, 1);
            }
        }


        for (char c : t.toCharArray()) {

    // If t has a char not in s → not an anagram
    if (!freqMap.containsKey(c)) {
        return false;
    }

        // Subtract from the count
        freqMap.put(c, freqMap.get(c) - 1);

        // If count goes negative → too many of that character in t
        if (freqMap.get(c) < 0) {
            return false;
        }
    }

    return true;

    }
}
