using LeetCode;

// var a = new TreeNode(
//     val: 1,
//     left: new TreeNode(
//         val: 7,
//         left: new TreeNode(val: 7),
//         right: new TreeNode(val: -8)),
//     right: new TreeNode(val: 0));

var a = new TreeNode(
    val: -100,
    left: new TreeNode(
        val: -200,
        left: new TreeNode(val: -20),
        right: new TreeNode(val: -5)),
    right: new TreeNode(val: -300, left: new TreeNode(-10)));

// var a = new TreeNode(
//     val: 1,
//     left: new TreeNode(val: 2),
//     right: new TreeNode(val: 3));

Console.WriteLine(new MaximumLevelSumofaBinaryTree1161().MaxLevelSum(a));