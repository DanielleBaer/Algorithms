namespace Search.Algorithms
{
    internal class BinaryTreeAlgorithm
    {
        private class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        private class BinarySearchTree
        {
            public static void PreOrderTraversal(Node root)
            {
                if (root == null)
                    return;

                Console.WriteLine(root.Data + " ");

                PreOrderTraversal(root.Left);
                PreOrderTraversal(root.Right);
            }
        }

        public void ExecuteBinaryTree()
        {
            Node rootNode = new();
            rootNode.Data = 4;

            Node nodeOne = new();
            nodeOne.Data = 1;

            Node nodeThree = new();
            nodeThree.Data = 3;

            Node nodeEight = new();
            nodeEight.Data = 8;

            Node nodeNine = new();
            nodeNine.Data = 9;

            Node nodeSix = new();
            nodeSix.Data = 6;

            rootNode.Left = nodeOne;
            rootNode.Right = nodeThree;
            nodeOne.Left = nodeEight;
            nodeOne.Right = nodeNine;
            nodeThree.Left = nodeSix;

            BinarySearchTree.PreOrderTraversal(rootNode);
        }
    }
}