class Solution {
public
    static vectorvectorint findWinners(const vectorvectorint& matches) noexcept {
        vectorvectorint ans(2);
        
        unordered_setint win;
        unordered_mapint, int loss;
        
        for (const vectorint& match  matches) {
            win.insert(match[0]);
            ++loss[match[1]];
        }
        
        for (int p  win)
            if (loss.find(p) == end(loss)) ans[0].push_back(p);
        
        for (auto [p, l]  loss)
            if (l == 1) ans[1].push_back(p);
        
        sort(begin(ans[0]), end(ans[0]));
        sort(begin(ans[1]), end(ans[1]));
        return ans;
    }
    
};