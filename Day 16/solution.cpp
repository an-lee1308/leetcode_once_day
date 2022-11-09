class Solution {
public:
    string makeGood(string s) {
        return accumulate(begin(s), end(s), string (""),
            [](string &acc, const char& c){
                if(abs(acc.back() - c) == 32) acc.pop_back(); else acc += c;
                return move(acc);
            }
        );
    }
};