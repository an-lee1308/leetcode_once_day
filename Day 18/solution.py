Cách tiếp cận của mình:
- Vì mảng đã được sắp xếp nên chỉ cần 1 vòng lặp rồi so sánh giá trị hiện tại ở index với giá trị ngay sau đó.​
Nếu bằng nhau thì xóa thằng sau, tự động thằng kế tiếp sẽ thế chỗ -> so sánh tiếp, đến khi nào không bằng nhau nữa thì thằng giá trị hiện tại sẽ là duy nhất -> index + 1 để bắt đầu so sánh thằng tiếp theo và lặp lại những bước trên​
Python:
class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        index = 0
        while index < len(nums)-1:
            if nums[index] == nums[index+1]:
                nums.remove(nums[index+1])
            else:
                index += 1  
        return len(nums)