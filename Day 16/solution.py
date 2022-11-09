#1
return reduce(lambda acc, x: acc[:-1] if len(acc) != 0 and acc[-1] != x and acc[-1].upper() == x.upper() else acc + x, s)
#2
class Solution:
    def makeGood(self, s: str) -> str:
        length = len(s)
        for i in range(0, len(s)):
            try:
                if s[i] == s[i+1].lower() and s[i+1].isupper():
                    s = s.replace(f"{s[i]}{s[i+1]}", "", 1)

                elif s[i] == s[i+1].upper() and s[i+1].islower():
                    s = s.replace(f"{s[i]}{s[i+1]}", "", 1)
            except IndexError:
                break
        if length == len(s):
            return s
        return self.makeGood(s)