public class Solution {
    public string RemoveStars(string s) {
        StringBuilder sb = new StringBuilder();

        foreach(char c in s){
            if(c == '*'){
                sb.Length -= 1;
            }
            else{
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}