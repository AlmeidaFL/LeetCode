using LeetCode;

// var a = new TreeNode(
//     val: 1,
//     left: new TreeNode(
//         val: 7,
//         left: new TreeNode(val: 7),
//         right: new TreeNode(val: -8)),
//     right: new TreeNode(val: 0));

// var a = new TreeNode(
//     val: -100,
//     left: new TreeNode(
//         val: -200,
//         left: new TreeNode(val: -20),
//         right: new TreeNode(val: -5)),
//     right: new TreeNode(val: -300, left: new TreeNode(-10)));

// var a = new TreeNode(
//     val: 1,
//     left: new TreeNode(val: 2),
//     right: new TreeNode(val: 3));

var a = new TreeNode(
     val: 1,
     left: new TreeNode(val: 2, left: new(4), new(5)),
     right: new TreeNode(val: 3, right: new(6)));

Console.WriteLine(new SmallestSubtreewithalltheDeepestNodes865().SubtreeWithAllDeepest(a).val);