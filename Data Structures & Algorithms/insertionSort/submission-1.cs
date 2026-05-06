/*
Given a list of key-value pairs, sort the list by key using Insertion Sort. 
Return a list of lists showing the state of the array after each insertion. 
If two key-value pairs have the same key, maintain their relative order in the sorted list.
*/


// Definition for a pair
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
    public List<List<Pair>> InsertionSort(List<Pair> pairs) 
    {
        List<List<Pair>> result = new List<List<Pair>>();

        for(int i = 0; i < pairs.Count; i++)
        { 
            int j = i - 1;
            while(j >= 0 && pairs[j + 1].Key < pairs[j].Key)
            { 
                Pair temp = pairs[j + 1];
                pairs[j + 1] = pairs[j];
                pairs[j] = temp;
                j -= 1;
            }
            result.Add(new List<Pair>(pairs));
        }
        return result;
    }
}