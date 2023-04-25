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
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if(head==null)return null; /* Outlier*/
        if(head.next==null && head.val==val)return null; /* Base case */
        if(head.next==null)return head; /* Base case */
        ListNode node;
        if(head.val==val){ /* In case we need to remove the head*/
            node=head.next; 
            head.next=null; /* Removing the head */
            return RemoveElements(node,val); /*Continuing with the rest of the list */
        }
        /* If we do not have to remove the head */
        node=RemoveElements(head.next,val); /* We continue with the rest of the nodes */
        head.next=node; /* We link the head to the new next element*/
        return head; /* We return the head */
    }
}
