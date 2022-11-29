class RandomizedSet {
    
    //use dict to bond index and value for array
    var dict = [Int:Int]()
    var arr = [Int]()
    
    init() {
	
    }
    
    func insert(_ val: Int) -> Bool {
        if let _ = dict[val] { return false }
        // store in arr here
        arr.append(val)
        // store in dict here
        dict[val] = arr.count-1
        return true
    }
    
    func remove(_ val: Int) -> Bool {
        guard let index = dict[val] else { return false }
		
        // remove from dict here
        dict[val] = nil
        
        // remove from arr here
        if index == arr.count-1 {
            arr.removeLast()
        } else {
            // suggest to choose end or tail index to swap or replace, since if we choose start index, and then once we removed one element, every index would be changed(-1 position), which is hard to handle.
            let replaceVal = arr.last!
            arr.swapAt(index, arr.count-1)
            arr.removeLast()
            dict[replaceVal] = index
        }
        return true
    }
    
    func getRandom() -> Int {
        return arr.randomElement()!
    }
}