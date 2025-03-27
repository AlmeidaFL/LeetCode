namespace LeetCode;

public class AddTwoNumbers2
{ 
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var totalNode = new ListNode();
        var linkNode = totalNode;
        var additionalSum = 0;
        do
        {
            var nextNode = new ListNode();
            totalNode.next = nextNode;
            var l1Val = l1.val;
            var l2Val = l2.val;
            var sum = l1Val + l2Val + additionalSum;
            var rest = sum % 10;
            var divisionMultiplier = (int)Math.Round(sum / 10m, MidpointRounding.ToZero);
            nextNode.val = rest;
            additionalSum = divisionMultiplier;
            
            l1 = l1.next;
            l2 = l2.next;
            totalNode = nextNode;
        } while (l1 != null && l2 != null);

        while (l2 != null)
        {
            var nextNode = new ListNode();
            var sum = l2.val + additionalSum;
            var rest = sum % 10;
            var divisionMultiplier = (int)Math.Round(sum / 10m, MidpointRounding.ToZero);
            nextNode.val = rest;
            additionalSum = divisionMultiplier;

            totalNode.next = nextNode;
            l2 = l2.next;
            totalNode = nextNode;
        }
        
        while (l1 != null)
        {
            var nextNode = new ListNode();
            var sum = l1.val + additionalSum;
            var rest = sum % 10;
            var divisionMultiplier = (int)Math.Round(sum / 10m, MidpointRounding.ToZero);
            nextNode.val = rest;
            additionalSum = divisionMultiplier;
            totalNode.next = nextNode;
            l1 = l1.next;
            totalNode = nextNode;
        }

        if (additionalSum > 0)
        {
            var nextNode = new ListNode(additionalSum);
            totalNode.next = nextNode;
        }
        
        // Removing empty node added in first interaction
        linkNode = linkNode.next;
        return linkNode;
    }
}