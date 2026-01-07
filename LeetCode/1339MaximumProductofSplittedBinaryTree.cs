namespace LeetCode;

public class MaximumProductofSplittedBinaryTree1339
{
    private const int Billion = 1_000_000_007;
    
    public int MaxProduct(TreeNode root) {
        var totalSum = GetTotalSum(root);
        long max = 0;
        GetMaxMultiplication(root, totalSum, ref max);
        
        return (int)(max % Billion);
    }

    public long GetMaxMultiplication(TreeNode? root, long totalSum, ref long max)
    {
        if (root == null)
            return 0;
        
        var x = GetMaxMultiplication(root.left, totalSum, ref max);
        var y = GetMaxMultiplication(root.right, totalSum, ref max);
        var nodeVal = root.val + x + y;
        var otherTree = (totalSum - nodeVal);
        max = Math.Max((otherTree * nodeVal), max);
        return root.val + y + x;
    }
    
    public long GetTotalSum(TreeNode? root)
    {
        if (root == null)
            return 0;
        
        var x = GetTotalSum(root.left);
        var y = GetTotalSum(root.right);

        return root.val + x + y;
    }
}