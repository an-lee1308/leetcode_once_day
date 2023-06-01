public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if(grid[0][0] != 0){
            return -1;
        }
        var SIZE = grid.Length;
        Dictionary<(int, int),int> costs = new();
        PriorityQueue<(int,int,int),int> q = new(); //r,c,cost
        costs[(0,0)] = 1;
        q.Enqueue((0,0,1), 0);

        while(q.Count > 0){
            (var r, var c, var cost) = q.Dequeue();
            if(r == SIZE - 1 && c == SIZE - 1){
                return cost;
            }
            var steps = new[] {
                (r + 1, c), (r - 1, c), (r, c + 1), (r, c - 1), 
                (r - 1, c - 1), (r + 1, c + 1), (r - 1, c + 1), (r + 1, c - 1)
            };
            foreach((var nr, var nc) in steps){
                if(nr < 0 || nr >= SIZE || nc < 0 || nc >= SIZE || grid[nr][nc] != 0){
                    continue;
                }
                var nextCost = cost + 1 + Heuristic((nr, nc), (SIZE - 1, SIZE - 1));
                if(costs.TryGetValue((nr,nc), out var prevCost) && prevCost <= nextCost){
                    continue;
                }
                costs[(nr,nc)] = nextCost;
                q.Enqueue((nr, nc, cost + 1), nextCost);
            }
        }
        return -1;
    }

    public int Heuristic((int,int) start, (int,int) target){
        (var x1, var y1) = start;
        (var x2, var y2) = target;

        return Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
    }
}