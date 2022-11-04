class Solution {
public:
    int longestPalindrome(vector<string>& words) {
        unordered_map<string, int> um;
        int pairs = 0, mirrors = 0;
        for(string &s : words){
            string tmp = "";
            tmp += s[1];
            tmp += s[0];
            if(um[tmp]){
                ++pairs;
                --um[tmp];
                if(s[0] == s[1]) --mirrors;
            }else{
                ++um[s];
                if(s[0] == s[1]) ++mirrors;
            }
        }
        return 4 * pairs + 2 * (mirrors > 0);
    }
};