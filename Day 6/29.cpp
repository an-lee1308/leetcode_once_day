class Solution {
public:
    int earliestFullBloom(vector<int>& plantTime, vector<int>& growTime) {
        priority_queue<pair<int, int>> q;
        int n = plantTime.size();
        for(int i = 0; i < n; i++)
            q.push({growTime[i], plantTime[i]});

        int plant = 0, grow = 0;
        while(!q.empty()){
            plant += q.top().second;
            grow = max(grow, plant + q.top().first);
            q.pop();
        }
        return grow;
    }
};

class Solution {
public:
    int earliestFullBloom(vector<int>& plantTime, vector<int>& growTime) {
        vector<int> index(plantTime.size());
        iota(begin(index), end(index), 0);
        sort(begin(index), end(index), [&growTime](const int &i, const int &j){
            return growTime[i] > growTime[j];
        });
        int plant = 0, grow = 0;
        for(int &i : index){
            plant += plantTime[i];
            grow = max(grow, plant + growTime[i]);
        }
        return grow;
    }
};
