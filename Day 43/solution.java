class Solution {
    public boolean canVisitAllRooms(List<List<Integer>> rooms) {
        Stack<Integer> stack = new Stack<>();
        Set<Integer> visited = new HashSet<>();   
        visited.add(0);
        stack.add(0);

        while(!stack.isEmpty()) {
            int cur = stack.pop();
            List<Integer> keys = rooms.get(cur);
            for (int key : keys) {
                if (!visited.contains(key)){
                    stack.push(key);
                    visited.add(key);
                }
            }
        }
    
        return visited.size() == rooms.size();
    }   
}