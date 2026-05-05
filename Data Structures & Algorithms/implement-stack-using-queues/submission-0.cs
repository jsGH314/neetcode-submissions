public class MyStack 
{
    /*
    Implement a last-in-first-out (LIFO) stack using only two queues. 
    The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).
    */

    Queue<int> qStack;

    public MyStack() 
    {
        qStack = new Queue<int>();
    }
    
    public void Push(int x) //to the back of queue
    {
        qStack.Enqueue(x);
    }
    
    public int Pop() 
    {
        Queue<int> copyQ = qStack;
        qStack = new Queue<int>(qStack.Take(qStack.Count - 1));
        return copyQ.Last();
    }
    
    public int Top() //"peek"
    {
        return qStack.Last();
    }
    
    public bool Empty() => qStack.Count == 0;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */