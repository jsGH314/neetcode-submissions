/*
Given a list of key-value pairs, sort the list by key using Merge Sort. 
If two key-value pairs have the same key, maintain their relative order in the sorted list.
*/

// Definition for a pair.
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
    public List<Pair> MergeSort(List<Pair> pairs) 
    {
        if (pairs.Count <= 1) return pairs;

        int m = pairs.Count / 2;
        List<Pair> left = MergeSort(pairs.GetRange(0, m));
        List<Pair> right = MergeSort(pairs.GetRange(m, pairs.Count - m));
        return Merge(left, right);
    }

    public static List<Pair> Merge(List<Pair> left, List<Pair> right)
    {
        List<Pair> result = new List<Pair>();
        int i = 0, j = 0;
        while (i < left.Count && j < right.Count) 
        {
            if (left[i].Key <= right[j].Key) 
            {
                result.Add(left[i++]);
            } else 
            {
                result.Add(right[j++]);
            }
        }
        while (i < left.Count) result.Add(left[i++]);
        while (j < right.Count) result.Add(right[j++]);
        return result;
    }
}

