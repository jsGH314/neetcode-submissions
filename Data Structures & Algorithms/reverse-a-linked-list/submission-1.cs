/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution 
{
    public ListNode ReverseList(ListNode head) 
    {
        ListNode temp = head;
        List<int> nodeValues = new List<int>();

        if(head == null)
        {
            return head;
        }

        while(temp != null)
        {
            nodeValues.Add(temp.val);
            temp = temp.next;
        }

        nodeValues.Reverse();
        head = new ListNode(nodeValues[0], null);
        ListNode prevNode = head;

        for(int i = 1; i < nodeValues.Count(); i++)
        {
            ListNode current = new ListNode(nodeValues[i], null);
            if(prevNode.next == null)
            {
                prevNode.next = current;
                prevNode = current;
            }
        }
        return head;
    }
}
