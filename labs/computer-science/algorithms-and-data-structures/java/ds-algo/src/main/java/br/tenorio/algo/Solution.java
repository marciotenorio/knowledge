package br.tenorio.algo;

import java.util.HashMap;

public class Solution {
    public static Node copyRandomList(Node head) {
        if(head == null)
            return null;

        var map = new HashMap<Node, Node>();
        var currO = head;
        var currN = new Node(head.val);
        var headN = currN;
        map.put(currO, currN);

        while(currO.next != null) {
            currN.next = new Node(currO.next.val);
            map.put(currO.next, currN.next);

            currN = currN.next;
            currO = currO.next;
        }

        currN = headN;
        currO = head;
        while(currO != null) {
            currN.random = map.get(currO.random);
            currN = currN.next;
            currO = currO.next;
        }

        return headN;
    }

    public static void main(String[] args) {
        var n3 = new Node(3);
        var n2 = new Node(2);
        var n1 = new Node(1);

        n1.next = n2;
        n1.random = n2;

        n2.next = n3;
        n2.random = n3;

        n3.random = n1;

        copyRandomList(n1);
    }
}
