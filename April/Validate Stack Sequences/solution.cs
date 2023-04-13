public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        Stack<int> st = new Stack<int>();
        int m = pushed.Length;
        int i=0;
        int j=0;
        while(i<m && j<m){
            st.Push(pushed[i]);
            while(st.Count > 0 && j < m && st.Peek() == popped[j]){
                st.Pop();
                j++;
            }
            i++;
        }
        return st.Count == 0;
    }
}