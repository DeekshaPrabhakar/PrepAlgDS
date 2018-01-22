using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Trees
{
    class LevelOrderTraversal
    {       
        public static void Run()
        {
            TreeNode bt = new TreeNode(3);
            bt.left = new TreeNode(9);
            bt.right = new TreeNode(20);
            bt.right.left = new TreeNode(15);
            bt.right.right = new TreeNode(7);
            List<List<int>> list = new List<List<int>>();
            levelOrderTraverse(bt, 0, list);
            Util.Display(list);
        }

        private static void levelOrderTraverse(TreeNode A, int level, List<List<int>> levels)
        {
            if(A == null)
            {
                return ;
            }

            if (level >= levels.Count)
            {
                levels.Add(new List<int>());
            }
            levels[level].Add(A.val);

            levelOrderTraverse(A.left, level + 1, levels);
            levelOrderTraverse(A.right, level + 1, levels);           
        }
    }
}
