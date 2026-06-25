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
    // public ListNode ReverseList(ListNode head) {
    //     ListNode prev = null;
    //     ListNode cur = head;

    //     while (cur != null) {
    //         ListNode nextNode = cur.next;
    //         cur.next = prev;
    //         prev = cur;
    //         cur = nextNode;
    //     }
    //     return prev;
    // }

    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }

        var nextNode = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return nextNode;
    }
}
