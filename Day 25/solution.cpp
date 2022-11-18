        return n > 0 and (n%2==0 and self.isUgly(n//2) or n%3==0 and self.isUgly(n//3) or n%5==0 and self.isUgly(n//5)) or n == 1
