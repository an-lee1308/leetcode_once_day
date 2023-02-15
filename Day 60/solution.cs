public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        var n = num.Length;
        var resultNum = new List<int>(n);
        var carry = 0;
        for (int i = n-1; i >= 0; i--)
        {
            var k1 = k % 10;
            k /= 10;
            var result = num[i] + k1 + carry;            
            carry = result/10;
            result %= 10;
            resultNum.Add(result);
        }

        carry += k;
        while (carry > 0)
        {
            var result = carry % 10;
            carry /= 10;
            resultNum.Add(result);
        }

        resultNum.Reverse();
        return resultNum;
    }
}