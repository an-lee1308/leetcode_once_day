class RandomizedSet {
private:
    unordered_map<int,int>mp;
    vector<int>nums;
public:
    /** Initialize your data structure here. */
    RandomizedSet() {
        //we already initialize
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    bool insert(int val) {
        if(mp.find(val) != mp.end())     // already present
            return false;
        nums.emplace_back(val); // push_back value;
        mp[val] = nums.size() - 1; //nums last index
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    bool remove(int val) {
        if(mp.find(val) == mp.end())    //not in the map
            return false;
        //The below 3 line to make complexity O(1)
        //vector::erase will take O(log n), so we shift our last element to other location and we remove the last element that will take O(1)
        int last_value = nums.back(); // Last value
        mp[last_value] = mp[val]; // reassign the new index
        nums[mp[val]] = last_value; //change the last value to other location
        
        nums.pop_back(); //It'll take O(1)
        mp.erase(val);
        return true;
    }
    
    /** Get a random element from the set. */
    int getRandom() {
        return nums[rand() % nums.size()]; //randomly generate index 
    }
};