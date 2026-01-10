namespace LeetCode;

public class SmallestSubtreewithalltheDeepestNodes865 {
    public TreeNode SubtreeWithAllDeepest(TreeNode root)
    {
        var depthOfEachNode = new List<int>();
        var nodes = new List<TreeNode>();
        var depthOfTree = -1;
        var stack = new Stack<(TreeNode Node, State State, int Depth)>();

        stack.Push((root, State.Enter, 0));

        
        while (stack.Count > 0)
        {
            var (node, state, depth) = stack.Pop();

            if (depth > depthOfTree)
                depthOfTree = depth;
            
            depthOfEachNode.Add(depth);
            nodes.Add(node);
            
            if (state == State.Enter)
            {
                var left = node.left;
                var right = node.right;
                
                if (right != null)
                {
                    stack.Push((node, State.Exit, depth));
                    stack.Push((right, State.Enter, depth + 1));
                }
                
                if (left != null)
                {
                    stack.Push((node, State.Exit, depth));
                    stack.Push((left, State.Enter, depth + 1));
                }
            }
        }

        var minorDepth = int.MaxValue;
        var index = 0;

        var startIndex = depthOfEachNode.IndexOf(depthOfTree);
        var endIndex = depthOfEachNode.LastIndexOf(depthOfTree);
        var minorNode = int.MaxValue;
        for (var i = startIndex; i <= endIndex; i++)
        {
            if (depthOfEachNode[i] >= minorNode)
                continue;
            minorNode = depthOfEachNode[i];
            index = i;
        }
        
        return nodes[index];
    }

    enum State
    {
        Exit,
        Enter
    }
}