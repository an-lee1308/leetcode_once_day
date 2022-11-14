class Solution {
public:
    int removeStones(vector<vector<int>>& stones) {
        unordered_map<int, vector<int>> rows, cols;
        for(auto &e : stones){
            rows[e[0]].push_back(e[1]);
            cols[e[1]].push_back(e[0]);
        }
        
        int res = 0;
        bool visited[10001] = {false};
        for(auto &it : rows){
            if(visited[it.first]) continue;
            int connected = 0;
            queue<int> qrows({it.first});
            while(!qrows.empty()){
                int r = qrows.front();
                qrows.pop();
                if(visited[r]) continue;
                visited[r] = true;
                connected += rows[r].size();
                for(int &c : rows[r])
                    for(int &e : cols[c])
                        if(!visited[e]) qrows.push(e);
            }
            res += connected - 1;
        }
        return res;
    }
};


//
class Solution {
    unordered_map<int, int> parent;
    int ufind(int x) {
        if (auto it = parent.find(x); it != parent.end()) {
            if (it->second != x)
                return it->second = ufind(it->second);
            return x;
        }
        return parent[x] = x;
    }
    
    void umerge(int x, int y) {
        x = ufind(x);
        y = ufind(y);
        if (x != y)
            parent[x] = y;
    }
    
public:
    int removeStones(vector<vector<int>>& stones) {
        int component = 0;
        for (auto &ss : stones) {
            int r = ss[0] + 1, c = ss[1] + 1;
            int ur = ufind(r), uc = ufind(c << 14);
            umerge(ur, uc);
        }
        return stones.size() - count_if(begin(parent), end(parent), [](auto &p) { return p.first == p.second; });
    }
};