using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    class HeightOfTheTree
    {
        public static void Run()
        {

            TreeNode bt = new TreeNode(1);
            bt.left = new TreeNode(2);
            bt.right = new TreeNode(3);
            bt.left.left = new TreeNode(4);
            bt.left.right = new TreeNode(5);

            Console.WriteLine(getHeight(bt));
        }


        public static int getHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = getHeight(root.left);
                int rightHeight = getHeight(root.right);

                if (leftHeight > rightHeight)
                {
                    return leftHeight + 1;
                }
                else
                {
                    return rightHeight + 1;
                }
            }
        }
    }
}
