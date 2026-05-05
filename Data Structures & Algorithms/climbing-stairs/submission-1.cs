public class Solution 
{
    /*
        You are given an integer n representing the number of steps to reach the top of a staircase. 
        You can climb with either 1 or 2 steps at a time.

        Return the number of distinct ways to climb to the top of the staircase.
    */
    public int ClimbStairs(int n) 
    {     
        int one = 1; // dp[i-1]
        int two = 1; // dp[i-2]

        for(int i = 0; i < n - 1; i++)
        {
            int temp = one;
            one = one + two; // new dp[i]
            two = temp;      // old dp[i-1] becomes new dp[i-2]
        }

        return one;
    }
}