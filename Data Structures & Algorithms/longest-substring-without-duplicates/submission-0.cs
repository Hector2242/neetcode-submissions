public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // HashSet<char> seen = new HashSet<char>();
        // char[] arr = s.ToCharArray();

        // foreach(char st in arr){
        //     if(!seen.Contains(st)){
        //         seen.Add(st);
        //     }
        // } 

        // return seen.Count
        int best = 0;
        int left = 0;
        HashSet<char> seen = new HashSet<char>();

        for (int right = 0; right < s.Length; right++) {
            while (seen.Contains(s[right])) {
                seen.Remove(s[left]);
                left++;
            }
            seen.Add(s[right]);
            best = Math.Max(best, right - left + 1);
        }

        return best;

    }
}
