def findWinners(self, matches: List[List[int]]) -> List[List[int]]:
  a, b = zip(*matches)
  return [sorted(set(a).difference(set(b))), sorted([i[0] for i in takewhile(lambda n: n[1]==1, Counter(b).most_common()[::-1])])]