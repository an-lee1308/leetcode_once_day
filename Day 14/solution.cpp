class Solution {
public:
    vector<string> findWords(vector<vector<char>>& board, vector<string>& words) {
        array<vector<pair<int, int>>, 26> charToStartPos;
        array<bool, 26> charSet = {false};

        for (int i = 0; i < board.size(); ++i) {
            for (int j = 0; j < board[0].size(); ++j) {
                charToStartPos[board[i][j] - 'a'].emplace_back(i,j);
                charSet[board[i][j]-'a'] = true;
            }
        }
       
        vector<string> result;
        for (auto &word : words){
            if (!isContain(charSet, word)) continue;
               
            auto &startPosts = charToStartPos[word.front() - 'a'];
            auto &startPostsR = charToStartPos[word.back() - 'a'];
           
            if (startPosts.size() <= startPostsR.size()) {
                for (auto pos : startPosts){
                    if (dfs(board, word, pos.first, pos.second)){
                        result.push_back(word);
                        break;
                    }
                }
            } else {
                string wordR(word.rbegin(), word.rend());
                for (auto pos : startPostsR){
                    if (dfs(board, wordR, pos.first, pos.second)){
                        result.push_back(word);
                        break;
                    }
                }
            }
        }
        return result;
    }
   
    bool isContain(const array<bool, 26> &charSet, const string& s){
        for (auto c : s){
            if (!charSet[c - 'a']) return false;
        }
        return true;
    }
   
    bool dfs(vector<vector<char>> &board, const string& word, int i, int j, int pos = 0) {
        if (pos == word.size()) return true;
        if (i < 0 || i >= board.size() || j < 0 || j >= board[0].size() || board[i][j] != word[pos]){
            return false;
        }
       
        // backup then invalid this cell
        char tmp = board[i][j];
        board[i][j] = '\0';
        bool result =   dfs(board, word, i+1, j, pos + 1)
                    ||  dfs(board, word, i-1, j, pos + 1)
                    ||  dfs(board, word, i, j+1, pos + 1)
                    ||  dfs(board, word, i, j-1, pos + 1);
       
        // restore the cell
        board[i][j] = tmp;
        return result;
    }