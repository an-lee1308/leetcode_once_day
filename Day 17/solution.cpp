class Solution {
public:
    string removeDuplicates(string s) {
        return accumulate(begin(s), end(s), string(""), [](string &acc, const char &c){
            if(acc.back() == c) acc.pop_back(); else acc += c;
            return move(acc);
        });
    }
};