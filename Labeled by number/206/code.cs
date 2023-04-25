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
    /* Reversed a linked list and returns its head. The Listnode structure is described above*/
    public ListNode ReverseList(ListNode head) {
        if(head==null) return null; /* Outlier*/
        if(head.next==null)return head; /* Base case*/
        ListNode node=head.next; /* We need to store head.next, because we are going to update it to null*/
        head.next=null;          /* since it will be the end of the list*/ 
        ListNode newHead=ReverseList(node);/* We reverse the rest of the list from node, and store the new*/
                                           /* head */
        node.next=head; /* link node to the head in the correct direction*/
        return newHead; /* return the new head*/
    }
}
