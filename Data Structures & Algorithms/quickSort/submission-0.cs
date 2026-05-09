// public class Pair {
//     public int Key;
//     public string Value; 
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution 
{
    public List<Pair> QuickSort(List<Pair> pairs) 
    {
        QuickSortHelper(pairs, 0, pairs.Count - 1);
        return pairs;
    }

    private void QuickSortHelper(List<Pair> arr, int s, int e)
    {
        if(e - s + 1 <= 1)
        {
            return;
        }

        Pair pivot = arr[e];
        int left = s;

        for(int i = s; i < e; i++)
        {
            if(arr[i].Key < pivot.Key)
            {
                Pair tmp = arr[left];
                arr[left] = arr[i];
                arr[i] = tmp;
                left++;
            }
        }
        // Move pivot in-between left & right sides
        arr[e] = arr[left];
        arr[left] = pivot;

        // Quick sort left side
        QuickSortHelper(arr, s, left - 1);

        // Quick sort right side
        QuickSortHelper(arr, left + 1, e);

    }
}
