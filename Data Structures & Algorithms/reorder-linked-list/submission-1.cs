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
    public void ReorderList(ListNode head) {
       if(head == null || head.next == null) return;

        ListNode slow = head, fast= head;
        while(fast != null && fast.next!=null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode cur = slow.next;
        ListNode prev = null;
        slow.next = null;
        while(cur!=null){
            ListNode next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        ListNode first = head, second = prev;
        while(second != null){
            ListNode tmp = first.next;
            ListNode tmp1= second.next;

            first.next = second;
            second.next = tmp;

            first = tmp;
            second= tmp1;
        }
    }

}
