public class Solution 
{
    public bool hasDuplicate(int[] nums) => nums.Length != nums.Distinct().Count();
}