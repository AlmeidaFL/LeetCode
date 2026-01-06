namespace LeetCode;

public class MaximumLevelSumofaBinaryTree1161 {
    public int MaxLevelSum(TreeNode root)
    {
        var queue = new Queue<(TreeNode Node, int Level)>();
        queue.Enqueue((root, 0));
        
        var totalSumPerLevel = 0;
        var totalSum = int.MinValue;
        var lastLevel = 0;
        var levelWithHigherSum = 0;
        
        while (queue.Count > 0)
        {
            var item = queue.Dequeue();

            if (item.Level > lastLevel)
            {
                if (totalSumPerLevel > totalSum)
                {
                    totalSum = totalSumPerLevel;
                    levelWithHigherSum = lastLevel;
                }
                totalSumPerLevel = 0;
            }
            
            if (item.Node.left != null)
                queue.Enqueue((item.Node.left, item.Level + 1));
            if (item.Node.right != null)
                queue.Enqueue((item.Node.right, item.Level + 1));
            
            lastLevel = item.Level;
            totalSumPerLevel += item.Node.val;
        }
        
        if (totalSumPerLevel > totalSum)
        {
            levelWithHigherSum = lastLevel;
        }
        
        
        return levelWithHigherSum + 1;
    }
}


 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
}
