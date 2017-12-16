using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    class IdenticalBinaryTrees
    {
        /*
        *       1
        *    2     3
        *  4    5
        */
        public static void Run()
        {
            TreeNode bt = new TreeNode(1);
            bt.left = new TreeNode(2);
            bt.left.left = new TreeNode(4);
            bt.left.right = new TreeNode(5);

            bt.right = new TreeNode(3);

            TreeNode bt2 = new TreeNode(1);
            bt2.left = new TreeNode(2);
            bt2.left.left = new TreeNode(4);
            bt2.left.right = new TreeNode(5);

            bt2.right = new TreeNode(3);


            Console.WriteLine("Identical Binary Trees: ");
            Console.WriteLine(isIdenticalRecursive(bt, bt2));
        }
               
        private static bool isIdenticalRecursive(TreeNode A, TreeNode B)
        {

            if(A == null && B == null)
            {
                return true;
            }

            if (A == null && B != null)
            {
                return false;
            }

            if (A != null && B == null)
            {
                return false;
            }

            return (A.val == B.val && isIdenticalRecursive(A.left, B.left) && isIdenticalRecursive(A.right, B.right));
        }
    }
}
