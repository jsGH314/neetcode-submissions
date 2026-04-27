public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> brackets = new Stack<char>();
        Dictionary<char, char> pairs = new Dictionary<char, char>()
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        foreach(char item in s)
        {
            if(!pairs.ContainsKey(item))
                brackets.Push(item);
            else if(brackets.Count == 0 || brackets.Pop() != pairs[item])
                return false;
        }
        return brackets.Count == 0;
        
    }
}
