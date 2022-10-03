import java.math.BigInteger;
class Solution {
    public final long mod = (long)(Math.pow(10,9) + 7);
    public int concatenatedBinary(int n) {
        if(n <= 0)
        {
            throw new IllegalArgumentException();
        }
        if(n == 1)
        {
            return 1;
        }
        long ans = 1;
        for(int i = 2; i <= n; i++)
        {
            long currentBitLength = (long)(BigInteger.valueOf(i).bitLength());
            ans = ((ans << currentBitLength) % mod + i) % mod;
        }
        return (int)ans;
    }
}
