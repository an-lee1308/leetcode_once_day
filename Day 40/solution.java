class MyQueue {
    private Stack<Integer> popStack;
    private Stack<Integer> pushStack;
    private void toRetrieveMode(){
        while(!pushStack.isEmpty()){
            popStack.push(pushStack.pop());
        }
    }
    private void toAddMode(){
        while(!popStack.isEmpty()){
            pushStack.push(popStack.pop());
        }
    }
    public MyQueue() {
        this.popStack = new Stack<>();
        this.pushStack = new Stack<>();
    }
   
    public void push(int x) {
        this.toAddMode();
        this.pushStack.push(x);
    }
   
    public int pop() {
        this.toRetrieveMode();
        return this.popStack.pop();
    }
   
    public int peek() {
        this.toRetrieveMode();
        return this.popStack.peek();
    }
   
    public boolean empty() {
        return (popStack.isEmpty() == pushStack.isEmpty());
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.push(x);
 * int param_2 = obj.pop();
 * int param_3 = obj.peek();
 * boolean param_4 = obj.empty();
 */