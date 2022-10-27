class Solution:
    def largestOverlap(self, img1: List[List[int]], img2: List[List[int]]) -> int:
        n=len(img1)
        s,t=[],[]
        for i in range(n):
            for j in range(n):
                if img1[i][j]==1:
                    s.append((i,j))
                if img2[i][j]==1:
                    t.append((i,j))
        h=collections.defaultdict(int)
        for p1 in t:
            for p2 in s:
                move=(p1[0]-p2[0],p1[1]-p2[1])
                h[move]+=1
        if h:
            return max(h.values())
        return 0