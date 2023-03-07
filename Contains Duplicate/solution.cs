public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {

        int count = 0;

        HashSet<int> set = new HashSet<int>(nums);  


        
        if(set.Count < nums.Length)
        {
            return true;
        }
        else
        {
            return false;
        }



    }
}