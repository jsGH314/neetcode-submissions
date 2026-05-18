public class Solution 
{
    public bool hasDuplicate(int[] nums) //=> nums.Length != nums.Distinct().Count();
    {
        var seen = new HashSet<int>();

        foreach(var item in nums)
        {
            //Hash sets can only contain unique elements,
            // so if we can't add the item, it means it's a duplicate
            if(!seen.Add(item))
            {
                return true;
            }
        }
        return false;
    }
}