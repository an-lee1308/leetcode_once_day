class Solution {
    public String makeGood(String s) {
        StringBuilder ans = new StringBuilder();
        ArrayDeque<Character> ad = new ArrayDeque<>();
        for(int i = 0; i < s.length(); i++)
        {
            if(ad.isEmpty() == false && Math.abs((int)(ad.peek() - s.charAt(i))) == 32)
            {
                ad.pop();
            }
            else
            {
                ad.push(s.charAt(i));
            }
        }
        for(Object c : ad.toArray())
        {
            ans.append(c.toString());
        }
        return ans.reverse().toString();
    }
}