using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    class ValidBST
    {
        public static void Run()
        {
              TreeNode bt = new TreeNode(50);
            bt.left = new TreeNode(10);
            bt.left.left = new TreeNode(5);
            bt.left.right = new TreeNode(30);
            bt.left.right.left = new TreeNode(20);
            bt.left.right.right = new TreeNode(40);

            bt.right = new TreeNode(80);
            bt.right.left = new TreeNode(70);
            bt.right.right = new TreeNode(90);
            bt.right.right.left = new TreeNode(85);
            Console.WriteLine(isValidBST(bt, int.MinValue, int.MaxValue));
        }


        public static bool isValidBST(TreeNode root, int min, int max)
        {
            if( root == null)
            {
                return true;
            }

            if(root.val < min || root.val > max)
            {
                return false;
            }
            return isValidBST(root.left, min, root.val - 1) && isValidBST(root.right, root.val + 1, max);
        }
    }
}
