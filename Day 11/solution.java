class Solution {
    public int minMutation(String start, String end, String[] bank) {
        Queue<String> q = new LinkedList<>();
        HashSet<String> visited = new HashSet<>();
        char[] c = new char[]{'A', 'T', 'G', 'C'};
        q.offer(start);
        visited.add(start);
        int ans = 0;
        while(!q.isEmpty())
        {
            int nodes = q.size();
            for(int i = 0; i < nodes; i++)
            {
                String current = q.poll();
                if(current.equals(end))
                {
                    return ans;
                }
                StringBuilder mutation = new StringBuilder();
                for(char j : c)
                {
                    for(int k = 0; k < current.length(); k++)
                    {
                        mutation.append(current.substring(0, k));
                        mutation.append(j);
                        mutation.append(current.substring(k + 1));
                        if(!visited.contains(mutation.toString()) &&
                           Arrays.stream(bank).anyMatch(mutation.toString()::equals))
                        {
                            q.offer(mutation.toString());