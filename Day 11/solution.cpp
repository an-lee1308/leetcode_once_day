class Solution {
public:
    int minMutation(string start, string end, vector<string>& bank) {
        unordered_set<string> us_bank, us_seen;
        queue<string> q;
        for(string &s : bank) us_bank.insert(s);
        q.push(start);
        us_seen.insert(start);
        int count = 0;
        while(!q.empty()){
            int n = q.size();
            for(int z = 0; z < n; ++z){
                string s = q.front();
                q.pop();
                if(s == end) return count;
                for(int i = 0; i < s.size(); i++){
                    for(char c : {'A', 'C', 'G', 'T'}){
                        string tmp = s;
                        tmp[i] = c;
                        if(us_bank.count(tmp) && !us_seen.count(tmp))
                            q.push(tmp), us_seen.insert(tmp);
                    }
                }
            }
            ++count;
        }
        return -1;
    }
};