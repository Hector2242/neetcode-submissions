public class Solution {
    public int CharacterReplacement(string s, int k) {

        Dictionary<char, int> count = new Dictionary<char, int>();
        int left = 0;
        int maxFreq = 0;
        int best = 0;
        
        for(int right = 0; right < s.Length; right ++){
            count.TryGetValue(s[right], out int n);
            count[s[right]] = n + 1;
            maxFreq = Math.Max(maxFreq, count[s[right]]);

            int windowLen = right - left + 1;
            if((windowLen - maxFreq) > k){
                count[s[left]] -= 1;
                left ++;
            }

            best = Math.Max(best, right - left + 1);

        }

        return best;

    }
}
