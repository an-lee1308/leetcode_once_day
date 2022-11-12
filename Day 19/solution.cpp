C++:
class MedianFinder {
public:
    priority_queue<int> max_heap;
    priority_queue<int, vector<int>, greater<int>> min_heap;
    MedianFinder() {
        
    }
    
    void addNum(int num) {
        if(max_heap.empty()){ // ca 2 deu rong
                max_heap.push(num);
                return;
        }
        int sizemax = max_heap.size();
        int sizemin = min_heap.size();
        if(sizemax < sizemin){ // o day ta co 2 truong hop
            if(min_heap.top() < num){
                max_heap.push(min_heap.top());
                min_heap.pop();
                min_heap.push(num);
            }
            else{
                max_heap.push(num);
            }
        }
        else{
            if(max_heap.top() > num){
                min_heap.push(max_heap.top());
                max_heap.pop();
                max_heap.push(num);
            }
            else{
                min_heap.push(num);
            }
            
        }

    }
    
    double findMedian() {
        int sizemax = max_heap.size();
        int sizemin = min_heap.size();
        if(sizemax == sizemin) return (min_heap.top() + max_heap.top()) / 2.;
        else if (sizemax > sizemin) return max_heap.top();
        else return min_heap.top();
        
    }
};

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder* obj = new MedianFinder();
 * obj->addNum(num);
 * double param_2 = obj->findMedian();
 */