public class Solution {
    public bool IsPalindrome(string s) {

        // Create an array large enough for the original string
        char[] chars = new char[s.Length];

        // i keeps track of where to put the next valid character
        int i = 0;

        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                chars[i] = char.ToLower(c);
                i++;
            }
        }

        // i is now the number of valid characters
        int length = i;

        // Two pointers
        int left = 0;
        int right = length - 1;

        while(left < right)
        {
            if(chars[left] != chars[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}