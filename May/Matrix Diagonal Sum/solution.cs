public class Solution {
    public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if (i == j)
                    {
                        sum += mat[i][j];
                        continue;
                    }
                    if (i + j == mat.Length - 1)
                    {
                        sum += mat[i][j];
                    }
                }
            }
            return sum;
        }
}