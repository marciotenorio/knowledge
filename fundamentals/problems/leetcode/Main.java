import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Stack;

public class Main {
    public static void main(String[] args) {
        ListNode l3 = new ListNode(4, null);
        ListNode l2 = new ListNode(2, l3);
        ListNode l1 = new ListNode(1, l2);

        ListNode l6 = new ListNode(4, null);
        ListNode l5 = new ListNode(3, l6);
        ListNode l4 = new ListNode(1, l5);

        var call = new Main();

        var result = call.mergeTwoLists(l1, l4);
        while(result != null) {
            System.out.println(result.val);
            result = result.next;
        }
    }

    // Input: list1 = [1,2<,4], list2 = [1,3<,4]
    // Output: [1,1,2,3,4,4]
    // 

    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                list1.next = mergeTwoLists(list1.next, list2);
                return list1;
            } else {
                list2.next = mergeTwoLists(list1, list2.next);
                return list2;
            }
        }
        if (list1 == null)
            return list2;
        return list1;
    }
}