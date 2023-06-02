public class Solution {

    public int MaximumDetonation(int[][] bombs) {
        Dictionary<int,List<int>> map = new ();
        
        for(int i=0; i < bombs.Length;i++){
            for(int j=0; j< bombs.Length;j++){
                if(j==i) 
                    continue;
                long sum = (long)(bombs[i][0]-bombs[j][0])*(long)(bombs[i][0]-bombs[j][0])+(long)(bombs[i][1]-bombs[j][1])*(long)(bombs[i][1]-bombs[j][1]);
                long self = (long)bombs[i][2]*(long)bombs[i][2];
                if(self >= sum){
                    if(!map.ContainsKey(i)){
                        map.Add(i,new List<int>());
                    }
                    map[i].Add(j);
                }
            }
        }
        int max = 1;
        
        for(int i=0;i< bombs.Length;i++){
            if(!map.ContainsKey(i)){
                continue;
            }
            int[] visit = new int[bombs.Length];
            int count = 1;
            Queue<int> q = new ();
            q.Enqueue(i);
            visit[i] = 1;
            while(q.Count > 0){
                int size = q.Count;
                while(size > 0){
                    int cur = q.Dequeue();
                    if(!map.ContainsKey(cur)){
                        size--;
                        continue;
                    }
                    foreach(int x in map[cur]){
                        if(visit[x]==1) 
                            continue;
                        q.Enqueue(x);
                        visit[x] = 1;
                        count++;
                    }
                    size--;
                }
            }
            max = Math.Max(max,count);
        }
        return max;
    }
}