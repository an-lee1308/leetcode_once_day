return 1 if n | target == 0 else 0 if n*target == 0 else sum(self.numRollsToTarget(n-1,k,target - i) for i in range(1, k+1))%int(1e9+7)
