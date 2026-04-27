public class Solution 
{
    public int[] ReplaceElements(int[] arr) 
    {
        //result array of the same size of input arr[]
        int[] ans = new int[arr.Length];
        //init as value of last position
        int rightMax = -1;

        //traverse from right to left
        for(int i = arr.Length - 1; i >= 0; i--)
        {
            ans[i] = rightMax;
            //update to be the max of itself and arr[i]
            rightMax = Math.Max(arr[i], rightMax);
        }
        return ans;
    }
}