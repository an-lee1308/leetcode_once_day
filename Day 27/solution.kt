class RandomizedSet() {

    /** Initialize your data structure here. */
    val map = HashMap<Int, Int>() // key: `val`, value:  index
    val arr = ArrayList<Int>()
    val random = Random()

    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    fun insert(`val`: Int): Boolean {
        if (map.contains(`val`)) return false

        arr.add(`val`)
        map[`val`] = arr.size - 1

        return true
    }

    /** Removes a value from the set. Returns true if the set contained the specified element. */
    fun remove(`val`: Int): Boolean {
        if (!map.contains(`val`)) return false

        val index = map[`val`]!!
        val last = arr.last()

        map[last] = index
        map.remove(`val`)

        arr[index] = last
        arr.removeAt(arr.size - 1)
        
        return true
    }

    /** Get a random element from the set. */
    fun getRandom(): Int {
        val index = random.nextInt(arr.size)

        return arr[index]
    }
}

// C++

class RandomizedSet {
public:
    /** Initialize your data structure here. */
    RandomizedSet() {
        
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    bool insert(int val) {
        if (map.count(val)) return false;
        arr.push_back(val);
        map[val] = arr.size() - 1;
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    bool remove(int val) {
        if (!map.count(val)) return false;
        int index = map[val];
        int last = arr.back();
        arr[index] = last;
        arr.pop_back();
        map[last] = index;
        map.erase(val);
        return true;
    }
    
    /** Get a random element from the set. */
    int getRandom() {
        int index = rand() % arr.size();
        return arr[index];
    }
private:
    unordered_map<int, int> map;
    vector<int> arr;
};