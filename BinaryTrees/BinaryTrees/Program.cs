using System;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            Console.WriteLine("PreOrder");
            TraversalUtil.PreOrderTraversal(root);
            Console.WriteLine();

            TreeNode root1 = new TreeNode(1);
            root1.left = new TreeNode(2);
            root1.right = new TreeNode(3);
            root1.left.left = new TreeNode(4);
            root1.left.right = new TreeNode(5);
            Console.WriteLine("InOrder Recursion");
            TraversalUtil.InOrderTraversal(root1);
            Console.WriteLine();

            Console.WriteLine("PostOrder Recursion");
            TraversalUtil.PostOrderTraversal(root1);
            Console.WriteLine();

            TreeNode root3 = new TreeNode(1);
            root3.left = new TreeNode(2);
            root3.right = new TreeNode(5);
            root3.left.left = new TreeNode(3);
            root3.left.right = new TreeNode(4);
            root3.left.left.left = new TreeNode(7);
            root3.right.right = new TreeNode(6);
            Console.WriteLine("Inorder Iteratavive");
            TraversalUtil.InOrderIteratetive(root3);

            Console.WriteLine();
            Console.WriteLine("PreOrder Iterative");
            TraversalUtil.PreOrderIteratetive(root3);

            Console.WriteLine();
            Console.WriteLine("PostOrder Iterative");
            TraversalUtil.PostOrderIteratetive(root3);

            Console.WriteLine();
            Console.WriteLine("Level order Traversal");
            TreeNode root5 = new TreeNode(1);
            root5.left = new TreeNode(2);
            root5.right = new TreeNode(3);
            root5.left.left = new TreeNode(4);
            root5.left.right = new TreeNode(5);
            root5.right.right = new TreeNode(8);
            root5.left.left.left = new TreeNode(6);
            root5.left.right.right = new TreeNode(7);
            root5.right.right.right = new TreeNode(9);
            TraversalUtil.LevelOrderTraversal(root5);

            Console.WriteLine();
            TreeNode root4 = new TreeNode(1);
            root4.left = new TreeNode(2);
            root4.right = new TreeNode(6);
            root4.left.left = new TreeNode(3);
            root4.left.right = new TreeNode(4);
            root4.left.right.right = new TreeNode(5);

            Console.WriteLine("Height of a tree");
            Console.WriteLine(CoreUtil.HeightBinaryTree(root4));

            Console.WriteLine("Nodes in a Binary Tree Iterative");
            Console.WriteLine(CoreUtil.NodesInBinaryTreeIterative(root4));

            Console.WriteLine("Nodes in a binary tree recursive");
            Console.WriteLine(CoreUtil.NodesInBinaryTreeRecursive(root4));

            Console.WriteLine("Number of leaf nodes iteratively");
            Console.WriteLine(CoreUtil.LeafNodesIterative(root4));

            Console.WriteLine("Number of leaf nodes recursively");
            Console.WriteLine(CoreUtil.LeafNodesRecursive(root4));

            Console.WriteLine("checked if a binary tree is balanced");
            TreeNode root6 = new TreeNode(5);
            root6.left = new TreeNode(2);
            root6.right = new TreeNode(7);
            Console.WriteLine(CoreUtil.IsBalanced(root4));
            Console.WriteLine(CoreUtil.IsBalanced(root6));

            Console.WriteLine("Check if a tree is a valid search tree");
            Console.WriteLine(CoreUtil.IsValidBST(root4,int.MinValue,int.MaxValue));
            Console.WriteLine(CoreUtil.IsValidBST(root6, int.MinValue, int.MaxValue));

            Console.WriteLine("Validate bianry search tree(check if bst is valid) iteratively");
            Console.WriteLine(CoreUtil.IsValidBSTIterative(root4));
            Console.WriteLine(CoreUtil.IsValidBSTIterative(root6));

            Console.WriteLine("Find the Least common ancestor");
            TreeNode root7 = new TreeNode(1);
            root7.left = new TreeNode(2);
            root7.right = new TreeNode(3);
            root7.left.left = new TreeNode(4);
            root7.left.right = new TreeNode(5);
            root7.right.left = new TreeNode(6);
            root7.right.right = new TreeNode(7);

            Console.WriteLine(CoreUtil.LeastCommonAncestorIterative(root7,4,5));

            Console.WriteLine("Good Nodes");
            Console.WriteLine(CoreUtil.GoodNodes(root6,int.MinValue,0));

            Console.WriteLine("Create a binary search tree");
            int[] arr = { 1, 2, 3, 4, 5 };
            TreeNode n = CoreUtil.CreateBst(arr);
            CoreUtil.PrintNodes(n);
        }
    }
}
