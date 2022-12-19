class Solution {

    class UnionFind {
        int[] root;
      
        public UnionFind(int size) {
            root = new int[size + 1];
            for (int i = 0; i < size + 1; i++){
                root[i] = i;
            }
        }
      
        public int find(int x) {
            if (root[x] == x) {
                return x;
            }
          
            return root[x] = find(root[x]);
        }
      
        public void union(int x, int y) {
            int rootX = find(x);
            int rootY = find(y);
          
            if (rootX != rootY) {
                root[rootX] = rootY;
            }
        }
    }
  
    public boolean validPath(int n, int[][] edges, int source, int destination) {
        UnionFind uf = new UnionFind(n);
      
        for (int[] edge : edges) {
            uf.union(edge[0], edge[1]);
        }
      
        if (uf.find(source) != uf.find(destination)) return false;
        return true;
    }
}