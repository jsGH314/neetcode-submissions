public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        List<int> ones = new List<int>();
        int onesCount = 0;

        foreach(int num in nums)
        {
            if(num == 1)
                onesCount++;
            else if(num == 0)
            {
                ones.Add(onesCount);
                onesCount = 0;
            }
        }
        ones.Add(onesCount);

        return ones.Max();
    }
}