public class Solution 
{
    /*
        You are given an integer n representing the number of steps to reach the top of a staircase. 
        You can climb with either 1 or 2 steps at a time.

        Return the number of distinct ways to climb to the top of the staircase.
    */
    public int ClimbStairs(int n) 
    {     
        if(n <= 2)
            return n;

        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }
}