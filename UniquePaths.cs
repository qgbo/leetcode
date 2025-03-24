public class Solution {
    static int[,] Cache;
    
    public int UniquePaths(int m, int n) 
    {
        if(Cache==null)
        {
            Cache= new int[m,n];
        }

        if(m==1 || n==1){
            return 1;
        }
        
        if (Cache[m - 1, n - 1] == 0) // 目标位置未计算
        {
            if (Cache[m - 2, n - 1] == 0) // 向上
            {
                Cache[m - 2, n - 1] = UniquePaths(m - 1, n);
            }

            if (Cache[m - 1, n - 2] == 0) // 向左
            {
                Cache[m - 1, n - 2] = UniquePaths(m, n - 1);
            }

            Cache[m - 1, n - 1] = Cache[m - 2, n - 1] + Cache[m - 1, n - 2];
        }

        Console.WriteLine($"{m-1},{n}: { Cache[m-2, n-1] },            {m},{n-1}: {Cache[m-1, n-2]}      {Cache[m-2, n-1] + Cache[m-1, n-2]}");
        return Cache[m-2, n-1] + Cache[m-1, n-2];
    }
}
