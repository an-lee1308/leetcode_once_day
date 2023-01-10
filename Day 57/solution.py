class Solution:
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        stack1 = deque()
        stack2 = deque()
        stack1.append(p)
        stack2.append(q)
        while stack1 and stack2:
            tmp1 = stack1.pop()
            tmp2 = stack2.pop()
            if tmp1 != None and tmp2 != None and tmp1.val == tmp2.val:
                stack1.append(tmp1.right)
                stack1.append(tmp1.left)
                stack2.append(tmp2.right)
                stack2.append(tmp2.left)
            elif tmp1 != None or tmp2 != None:
                return False
        return True