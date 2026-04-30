public class Solution 
{
    public int CalPoints(string[] operations) 
    {
        Stack<int> scoreStack = new Stack<int>();
        int n = operations.Length;
        int scoreSum = 0;

        for(int i = 0; i < n; i++)
        { 
            if(operations[i] == "+")
            {
                int top = scoreStack.Pop();
                int newScore = top + scoreStack.Peek();
                scoreStack.Push(top);
                scoreStack.Push(newScore);
            }
            else if(operations[i] == "C")
            {
                scoreStack.Pop();
            }
            else if(operations[i] == "D")
            {
                int top = scoreStack.Peek();
                scoreStack.Push(top*2);
            }
            else
            {
                scoreStack.Push(int.Parse(operations[i]));
            }
        }

        foreach(int item in scoreStack)
        {
            scoreSum += item;
        }

        return scoreSum;
        
    }
}