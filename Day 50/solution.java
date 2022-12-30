public List<List<Integer>> allPathsSourceTarget(int[][] graph) {
	var paths = new ArrayList<List<Integer>>();
	dfs(0, new ArrayDeque<>(List.of(0)), paths, graph);
	return paths;
}

// Recursive equation --> path(A, B) = A + path(neighbor of A, B).
private void dfs(int node, Deque<Integer> path, List<List<Integer>> paths, int[][] graph) {
	if (node == graph.length - 1) 
		paths.add(List.copyOf(path));
	else 
		for (var neighbor : graph[node]) {
			path.addLast(neighbor);
			dfs(neighbor, path, paths, graph);
			path.removeLast();
		}
}