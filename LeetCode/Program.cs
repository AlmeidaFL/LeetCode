// See https://aka.ms/new-console-template for more information

using LeetCode;

var node1A = new AddTwoNumbers2.ListNode(3);
var node1B= new AddTwoNumbers2.ListNode(7);


node1A.next = node1B;



var node2A = new AddTwoNumbers2.ListNode(9);
var node2B= new AddTwoNumbers2.ListNode(2);

node2A.next = node2B;



var node = AddTwoNumbers2.AddTwoNumbers(node1A,node2A);
var numbers = new List<int>();
while(node!=null)
{
    numbers.Add(node.val);
    node = node.next;
}

Console.WriteLine(string.Join(",",numbers));