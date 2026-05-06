public class ListNode 
{
    public int Value;
    public ListNode Next;
    public ListNode(int val = 0, ListNode next = null) 
    {
        this.Value = val;
        this.Next = next;
    }
}

public class LinkedList 
{
    ListNode Head;
    ListNode Tail;

    public LinkedList() 
    {
        Head = null;
        Tail = null;
    }

    public int Get(int index)
    {
        int i = 0;
        ListNode current = Head;

        while(i < index && current != null)
        {
            current = current.Next;
            i++;
        }

        if(current == null)
            return -1;
        
        return current.Value;
    }

    public void InsertHead(int val) 
    {
        ListNode newNode = new ListNode(val);
        newNode.Next = Head;
        Head = newNode;
        if (Tail == null) Tail = newNode;
    }

    public void InsertTail(int val) 
    {
        ListNode newNode = new ListNode(val);
        if (Tail == null) 
        {
            Head = Tail = newNode;
        } else 
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
    }

    public bool Remove(int index) 
    {
        if (Head == null) return false;
        if (index == 0) 
        {
            if (Head == Tail) Tail = null;
            Head = Head.Next;
            return true;
        }

        ListNode current = Head;
        for (int i = 0; i < index - 1; i++) 
        {
            if (current == null || current.Next == null) return false;
            current = current.Next;
        }

        if (current.Next == null) return false;
        if (current.Next == Tail) Tail = current;
        current.Next = current.Next.Next;
        return true;
    }

    public List<int> GetValues() 
    {
        List<int> res = new List<int>();
        ListNode curr = Head;
        while (curr != null) 
        {
            res.Add(curr.Value);
            curr = curr.Next;
        }
        return res;
    }
}