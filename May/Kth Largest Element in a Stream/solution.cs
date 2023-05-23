public class KthLargest 
{
    //we'll always maintain only top k largest elements in this queue
    //and queue will have elements in increasing order, so we can get Kth largest element by simply peeking the queue
    PriorityQueue<int, int> pq;

    //to store 'k'
    int k;
    

    public KthLargest(int k, int[] nums) {
        this.k = k;
        pq = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            Add(num);
        }
    }
    
    public int Add(int val) {
        //least element/value will have high priority and hence it'll be the first to be removed
        //higher valued elements will be at the end of queue
        pq.Enqueue(val, val);

        //maintain only k elements
        //this can be either a 'while' or a simple 'if' block, as it runs only once
        while (pq.Count > k)
        {
            pq.Dequeue();
        }

        return pq.Peek();
    }
}