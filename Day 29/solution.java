class Solution {
    public boolean closeStrings(String word1, String word2) {
        if(word1.length() != word2.length())
        {
            return false;
        }
        Map<Character, Integer> m1 = new HashMap<>();
        Map<Character, Integer> m2 = new HashMap<>();
        for(char c : word1.toCharArray())
        {
            m1.put(c, m1.getOrDefault(c, 0) + 1);
        }
        for(char c : word2.toCharArray())
        {
            m2.put(c, m2.getOrDefault(c, 0) + 1);
        }
        ArrayList<Integer> tmp1 = new ArrayList<>(m1.values());
        ArrayList<Integer> tmp2 = new ArrayList<>(m2.values());
        Collections.sort(tmp1);
        Collections.sort(tmp2);
        return m1.keySet().equals(m2.keySet()) &&
            tmp1.equals(tmp2);
    }
}