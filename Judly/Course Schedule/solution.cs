public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<List<int>> graph = new List<List<int>>(numCourses);
        for (int i = 0; i < numCourses; i++) {
            graph.Add(new List<int>());
        }
        
        foreach (int[] prerequisite in prerequisites) {
            int course = prerequisite[0];
            int prereq = prerequisite[1];
            graph[prereq].Add(course);
        }
        
        int[] visited = new int[numCourses];
        
        for (int course = 0; course < numCourses; course++) {
            if (!DFS(graph, visited, course)) {
                return false;
            }
        }
        
        return true;
    }