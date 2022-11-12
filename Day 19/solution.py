# first version:
    # addNum(): O(1)
    # findMedian(): O(nlogn)
class MedianFinder:

    def __init__(self):
        self.arr = []

    def addNum(self, num: int) -> None:
        self.arr.append(num)

    def findMedian(self) -> float:
        self.arr.sort()
        l = len(self.arr)
        if l % 2 == 0:
            return (self.arr[l//2-1]+self.arr[l//2])/2
        else:
            return self.arr[l//2]

# better version:
    # addNum(): O(logn)
    # findMedian():O(1)

class MedianFinder:

    def __init__(self):
        self.small = []
        self.large = []

    def addNum(self, num: int) -> None:
        heappush(self.small,-num)
        if len(self.small) > len(self.large)+1:
            heappush(self.large,-heappop(self.small))
        if self.large and -self.small[0] > self.large[0]:
            heappush(self.large,-heappop(self.small))
            heappush(self.small,-heappop(self.large))

    def findMedian(self) -> float:
        if len(self.small) > len(self.large):
            return -self.small[0]
        else:
            return (self.large[0]-self.small[0])/2