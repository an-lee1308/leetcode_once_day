class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> um;
        for(string &s : strs){
            int tab[26] = {0};
            for(char &c : s) tab[c - 'a']++;
            string tmp = "";
            for(int i = 0; i < 26; i++)
                tmp += "." + to_string(tab[i]);
            um[tmp].push_back(s);
        }
        vector<vector<string>> res;
        for(auto &it : um) res.push_back(it.second);
        return res;
    }
};