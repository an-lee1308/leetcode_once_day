public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int s = 0, e = letters.Length - 1;
        
        if (letters[letters.Length - 1] <= target) 
            return letters[0];

        while(s < e) {
            int mid = (s + e)/2;
            if (letters[mid] <= target) 
                s = mid + 1;
            else 
                e = mid;    
        }

        return letters[s];
    }
}