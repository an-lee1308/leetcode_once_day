class Solution {
    public boolean possibleBipartition(int n, int[][] dislikes) {
        Map<Integer, List<Integer>> graph = new HashMap<>();

        for(int[] dislike : dislikes) {
            graph.putIfAbsent(dislike[0], new ArrayList<>());
            graph.putIfAbsent(dislike[1], new ArrayList<>());
            graph.get(dislike[0]).add(dislike[1]);
            graph.get(dislike[1]).add(dislike[0]);
        }

        int[] color = new int[n + 1];
        Set<Integer> visited = new HashSet<>();
        Queue<Integer> queue = new LinkedList<>();
        for (int i = 1; i <= n; i++) {
            queue.add(n);
        }

        while(!queue.isEmpty()) {
            int cur = queue.poll();
            if (visited.contains(cur)) continue;

            if (color[cur] == 0) color[cur] = 1;

            if (graph.get(cur) == null) continue;

            for(int nb : graph.get(cur)) {
                if (!visited.contains(nb)){
                    color[nb] = color[cur] == 1 ? 2 : 1;
                    queue.add(nb);
                    continue;
                }
                if (color[nb] == color[cur]) return false;
            }

            visited.add(cur);
        }
        
        return true;
    }
}