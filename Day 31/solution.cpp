class Solution {
    public int magnificentSets(int n, int[][] edges) {
        int res=0;
        List<List<Integer>> G=construct(n, edges);
        boolean[] processed=new boolean[n];
        for(int i=0;i<n;++i){
            if(!processed[i]){
                int tmp=process(i, processed, n, G);
                if(tmp==-1) return -1;
                res=res+tmp;
            }
        }
        return res;
    }
    
    int process(int i, boolean[] processed, int n, List<List<Integer>> G){
        System.out.printf("i= %d\n", i);
        List<Integer> L=new ArrayList<>();
        dfs1(i, processed, L, G);
        int res=-1;
        for(int j=0;j<L.size();++j){
            res=Math.max(res, process2(L.get(j), G));
        }
        return res;
    }
    
    int process2(int i, List<List<Integer>> G){
        System.out.printf("i2= %d\n", i);
        int[] f=new int[G.size()];
        int n=G.size();
        f[i]=1;
        Queue<Integer> queue=new ArrayDeque<>();
        queue.add(i);
        while(queue.size()>0){
            int tmp=queue.remove();
            for(int j=0;j<G.get(tmp).size();++j){
                int v=G.get(tmp).get(j);
                if(f[v]==0){
                    queue.add(v);
                    f[v]=f[tmp]+1;
                }
                else{
                    if(f[v]-f[tmp]!=1 && f[tmp]-f[v]!=1){
                        return -1;
                    }
                }
            }
        }
        List<Integer> H=new ArrayList<>();
        boolean[] visited=new boolean[n];
        for(int j=0;j<G.get(i).size();++j){
            int v=G.get(i).get(j);
            if(!visited[v]){
                int h=dfs3(v, visited, f, G);
                System.out.printf("%d\n", h);
                H.add(h);
            }
        }
        Collections.sort(H, Collections.reverseOrder());
        if(H.size()==0) return 1;
        else if(H.size()==1) return H.get(0);
        else{
            return H.get(0)+H.get(1)-1;
        }
    }
    
    int dfs3(int i, boolean[] visited, int[] f, List<List<Integer>> G){
        int res=f[i];
        visited[i]=true;
        for(int j=0;j<G.get(i).size();++j){
            int v=G.get(i).get(j);
            if(!visited[v]){
                int tmp=dfs3(v, visited, f, G);
                res=Math.max(res, tmp);
            }
        }
        return res;
    }
    
    boolean dfs2(int i, List<List<Integer>> G, int[] f, int h){
        f[i]=h;
        for(int j=0;j<G.get(i).size();++j){
            int v=G.get(i).get(j);
            
            if(f[v]!=0){
                System.out.printf("%d %d %d %d\n", i, v, f[i], f[v]);
                if((int)Math.abs(f[v]-h)!=1){
                    return false;
                }
            }
            else{
                boolean ok=dfs2(v, G, f, h+1);
                if(!ok) return false;
            }
        }
        return true;
    }
    
    void dfs1(int i, boolean[] processed, List<Integer> L, List<List<Integer>> G){
        L.add(i);
        processed[i]=true;
        for(int j=0;j<G.get(i).size();++j){
            int v=G.get(i).get(j);
            if(!processed[v]){
                dfs1(v, processed, L, G);
            }
        }
    }
    
    List<List<Integer>> construct(int n, int[][] edges){
        List<List<Integer>> res=new ArrayList<>();
        for(int i=0;i<n;++i){
            res.add(new ArrayList<>());
        }
        for(int i=0;i<edges.length;++i){
            int u=edges[i][0];
            int v=edges[i][1];
            res.get(u-1).add(v-1);
            res.get(v-1).add(u-1);
        }
        return res;
    }
}