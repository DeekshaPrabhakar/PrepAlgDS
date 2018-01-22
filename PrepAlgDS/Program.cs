using PrepAlgDS.Arrays;
using PrepAlgDS.BinarySearch;
using PrepAlgDS.CalibrationOne;
using PrepAlgDS.Checkpoints;
using PrepAlgDS.HashTables;
using PrepAlgDS.Heaps;
using PrepAlgDS.LinkedLists;
using PrepAlgDS.Recursion;
using PrepAlgDS.Strings;
using PrepAlgDS.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepAlgDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunCalibrationThree();
            //RunBSTrees();
            RunTrees();
            //RunCalibrationTwo();
            //RunLinkedLists();
            //RunHashtables();
            //RunFirstPrep();
            //RunArrays();
            //RunStrings();
            //RunCalibrationOne();
            //RunCheckpoints();
            //RunHeaps();
            //RunRecursion();
            Console.ReadLine();
        }

        private static void RunRecursion()
        {
            //RecursiveStaircase.Run();
            //PermuteString.Run();
            //LetterPhone.Run();
            //nQueens.Run();
            Sublist.Run();
        }

        private static void RunCalibrationThree()
        {
            //int keys_size = 0;
            //keys_size = Convert.ToInt32(Console.ReadLine());
            //int[] keys = new int[keys_size];
            //int keys_item;
            //for (int keys_i = 0; keys_i < keys_size; keys_i++)
            //{
            //    keys_item = Convert.ToInt32(Console.ReadLine());
            //    keys[keys_i] = keys_item;
            //}
            //createBST(keys);


            //int noOfQueries = 0;
            //noOfQueries = Convert.ToInt32(Console.ReadLine());
            //List<List<int>> input = new List<List<int>>();

            //int noOfNodes = 0;
            //List<int> nodes = null;

            //for (int keys_i = 0; keys_i < noOfQueries; keys_i++)
            //{
            //    noOfNodes = Convert.ToInt32(Console.ReadLine());
            //    nodes = new List<int>();
            //    string numbers = Console.ReadLine();
            //    string[] numArray = numbers.Split(' ');
            //    foreach (string num in numArray)
            //    {
            //        nodes.Add(Convert.ToInt32(num));
            //    }

            //    input.Add(nodes);
            //}

            //bool output = false;

            //foreach (List<int> l in input)
            //{
            //    output = isSequencePreOrder(l);
            //    Console.WriteLine(output == true ? "YES" : "NO");
            //}

            //int[] res;
            //int nums_size = 0;
            //nums_size = Convert.ToInt32(Console.ReadLine());
            //int[] nums = new int[nums_size];
            //int nums_item;
            //for (int nums_i = 0; nums_i < nums_size; nums_i++)
            //{
            //    nums_item = Convert.ToInt32(Console.ReadLine());
            //    nums[nums_i] = nums_item;
            //}

            //int maxes_size = 0;
            //maxes_size = Convert.ToInt32(Console.ReadLine());
            //int[] maxes = new int[maxes_size];
            //int maxes_item;
            //for (int maxes_i = 0; maxes_i < maxes_size; maxes_i++)
            //{
            //    maxes_item = Convert.ToInt32(Console.ReadLine());
            //    maxes[maxes_i] = maxes_item;
            //}

            //res = counts(nums, maxes);
            //for (int res_i = 0; res_i < res.Length; res_i++)
            //{
            //    Console.WriteLine(res[res_i]);
            //}
            
        }

        private static void RunHeaps()
        {
           //PrepAlgDS.Heaps.MergeSortedLists.Run();
        }

        //static int[] counts(int[] nums, int[] maxes)
        //{
        //    //List<int> output = new List<int>(maxes.Length);
        //    int[] output = new int[maxes.Length];

        //    MinHeapImplementation heap = new MinHeapImplementation();

        //    foreach(int num in nums)
        //    {
        //        heap.enqueue(num);
        //    }

        //    while (heap.getCount() > 0)
        //    {
        //        Int64 min = heap.getMinimum();

        //        for (int i = 0; i < maxes.Length; i++)
        //        {
        //            if (min <= maxes[i])
        //            {
        //                output[i] += 1;
        //            }

        //        }
        //    }
            

        //    return output;
        //}


        private static bool isSequencePreOrder(List<int> nodesList)
        {
            bool isPreOrder = false;
            TreeNode A = createBSTFomPreOrder(nodesList);
            if(isValidBST(A))
            {
                isPreOrder = true;
            }
            return isPreOrder;
        }

        protected static TreeNode createBSTFomPreOrder(List<int> arr)
        {
            TreeNode root = new TreeNode(arr[0]);//root first
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            for (int i = 1; i < arr.Count; i++)
            {
                TreeNode currentNode = null;

                while (stack.Count != 0 && arr[i] > stack.Peek().val)
                {
                    currentNode = stack.Pop();
                }

                if (currentNode != null)
                {//right subtree
                    currentNode.right = new TreeNode(arr[i]);
                    stack.Push(currentNode.right);
                }
                else
                {//left subtree
                    currentNode = stack.Peek();
                    currentNode.left = new TreeNode(arr[i]);
                    stack.Push(currentNode.left);
                }
            }
            return root;

        }


        public static bool isValidBST(TreeNode A)
        {
            return validBST(A, int.MinValue, int.MaxValue);
        }

        public static bool validBST(TreeNode root, int min, int max)
        {
            if(root == null)
            {
                return true;
            }

            if(root.val < min || root.val > max)
            {
                return false;
            }

            return validBST(root.left, min, root.val - 1) && validBST(root.right, root.val + 1, max);

        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
                       
            public TreeNode(int x)
            {
                this.val = x;
                this.left = this.right = null;
            }

        }

        private static int counter = 0;
        public static void createBST(int[] keys)
        {
            counter = 0;
            TreeNode root = null;
            foreach (int key in keys)
            {
                if(root != null)
                {
                    insert(root, key);
                }
                else
                {
                    root = new TreeNode(key);
                }
                Console.WriteLine(counter);
            }
        }

        private static void insert(TreeNode root, int key)
        {
            counter += 1;
            if(key < root.val)
            {
                if(root.left == null)
                {
                    root.left = new TreeNode(key);
                    //return root.left;
                }
                else
                {
                    insert(root.left, key);
                    //return insert(root.left, key);
                }
            }
            else
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(key);
                    //return root.right;
                }
                else
                {
                    insert(root.right, key);
                    //return insert(root.right, key);
                }
            }
        }       
       

        private static void RunBSTrees()
        {
            //RotatedSortedArraySearch.Run();
            //SortedInsetPosition.Run();
            //PreOrderTraversal.Run();
            //MatrixSearch.Run();
            //RotatedArray.Run();
            //ValidBST.Run();
            //CountOccurences.Run();
            //SquareRoot.Run();
            HeightOfTheTree.Run();
        }

        private static void RunTrees()
        {
            //IdenticalBinaryTrees.Run();
            //CountLeafNodes.Run();
            //BFSTraversal.Run();
            //SymmetricBinaryTree.Run();
            //InorderTraversal.Run();
            //LevelOrderTraversal.Run();
            SortedListToBST.Run();
        }

        public class LinkedListNode
        {
            public int val;
            public LinkedListNode next;
        }

        private static void RunCalibrationTwo()
        {
            //string res;
            //string s;
            ////s = Console.ReadLine();

            //res = firstRepeatedWord("He had Had    quite enough of this he.");
            //Console.WriteLine(res);

            //LinkedListNode head = new LinkedListNode();
            //head.val = 1;
            //head.next = new LinkedListNode();
            //head.next.val = 2;
            //head.next.next = new LinkedListNode();
            //head.next.next.val = 3;
            //head.next.next.next = new LinkedListNode();
            //head.next.next.next.val = 4;
            //head.next.next.next.next = new LinkedListNode();
            //head.next.next.next.next.val = 5;
            //DisplayLinkedList2(head);
            //Console.WriteLine();
            //DisplayLinkedList2(removeNodes(head, 3));

            //int t = int.Parse(Console.ReadLine());
            //List<string> inputStrings = new List<string>();
            //for(int i=0; i<t;i++)
            //{
            //    inputStrings.Add(Console.ReadLine());
            //}


            //List<int> outputStrings = new List<int>();
            //for (int i = 0; i < t; i++)
            //{
            //    outputStrings.Add(anagramDiff(inputStrings[i]));
            //}

            //foreach(int i in outputStrings)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(anagramDiff("hhpddlnnsjfoyxpciioigvjqzfbpllssuj"));
            //Console.WriteLine(anagramDiff(""));
        }


        private static int anagramDiff(string str)
        {
            int count = 0;
            bool isEven = str.Length % 2 == 0 ? true : false;

            if (isEven)
            {
                string bookOne = str.Substring(0, (str.Length / 2));
                string bookTwo = str.Substring((str.Length / 2));

                char[] bookOneArray = bookOne.ToCharArray();
                Array.Sort(bookOneArray);

                char[] bookTwoArray = bookTwo.ToCharArray();
                Array.Sort(bookTwoArray);

                if (new string(bookOneArray) == new string(bookTwoArray))
                {
                    return 0;
                }

                Dictionary<char, int> bookTwoDict = new Dictionary<char, int>();
                for (int i = 0; i < bookTwoArray.Length; i++)
                {
                    if(bookTwoDict.ContainsKey(bookTwoArray[i]))
                    {
                        bookTwoDict[bookTwoArray[i]] += 1;
                    }
                    else
                    {
                        bookTwoDict.Add(bookTwoArray[i], 1);
                    }
                }

                for (int i = 0; i < bookOneArray.Length; i++)
                {
                    if (bookTwoDict.ContainsKey(bookOneArray[i]))
                    {
                        bookTwoDict[bookOneArray[i]] -= 1;
                        if (bookTwoDict[bookOneArray[i]] == 0)
                        {
                            bookTwoDict.Remove(bookOneArray[i]);
                        }
                    }
                    else
                    {
                        count += 1;
                    }
                }

            }
            else
            {
                //odd any number of replacements will not help since only replacement is allowed no add/sub
                return -1;
            }
            return count;
        }

        static LinkedListNode removeNodes(LinkedListNode list, int x)
        {
            LinkedListNode dummy = new LinkedListNode();
            dummy.next = list;
            LinkedListNode curr = list;
            LinkedListNode prev = dummy;

            while (curr != null)
            {
                if (curr.val > x)
                {
                    prev.next = curr.next;
                }
                else
                {
                    prev = curr;
                }
                curr = curr.next;
            }

            return dummy.next;
        }

        public static void DisplayLinkedList2(LinkedListNode list)
        {
            LinkedListNode curr = list;
            while (curr != null)
            {
                if (curr.next != null)
                {
                    Console.Write(curr.val + "->");
                }
                else
                {
                    Console.Write(curr.val);
                }
                curr = curr.next;
            }
        }
               
        private static string firstRepeatedWord(string s)
        {
            String result = "";
            s = s.Trim();
            s = s.Replace(",", "").Replace(":", "").Replace(";", "").Replace("-", "").Replace(".", "").Replace(",", "").Replace("\t", "");

            String[] words = s.Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    if (dict.ContainsKey(word))
                    {
                        return word;
                    }
                    else
                    {
                        dict.Add(word, 0);
                    }
                }
            }
            return result;
        }

        private static void RunHashtables()
        {
            TwoSum.Run();
            //Fraction.Run();
            //LongestSubstring.Run();
            //Anagram.Run();
        }

        private static void RunLinkedLists()
        {
            //ListCycle.Run();
            //MergeSortedLists.Run();
            //RemoveDuplicateSortedII.Run();
            //RemoveDuplicateSorted.Run();
            //AddTwoNumbers.Run();
            //PrintLinkedListReverseRecursive.Run();
        }

        private static void RunFirstPrep()
        {
            //Console.WriteLine(maxLength(new int[] { 3, 1, 2, 1 }, 4));
            Console.WriteLine(longestSubsequence("abc", "aedace"));
        }

        static int longestSubsequence(string x, string y)
        {
            int len = 0;
            System.Text.StringBuilder sbX = new System.Text.StringBuilder();
            System.Text.StringBuilder sbY = new System.Text.StringBuilder();


            for (int i = 0; i < y.Length;i++ )
            {
                if(x[i] == y[i])
                {
                    sbY.Append(y[i]);
                }
            }
            len = sbY.Length;
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //int i = 0;
                //char[] xArray = x.ToArray();

                //while(i < y.Length)
                //{
                //    if (isSubsequence(sb.ToString() + y[i], xArray))
                //    {
                //        sb.Append(y[i]);
                //        len = sb.Length > len ? sb.Length : len;
                //    }
                //    else
                //    {
                //        sb = new System.Text.StringBuilder();
                //    }
                //    i = i + 1;
                //}

                return len;
        }

        static bool isSubsequence(string partY, char[] x)
        {
            bool isSubsq = true;
            List<char> xList = x.ToList<char>();

            for (int i = 0; i < partY.Length; i++)
            {
                if (!xList.Contains(partY[i]))
                {
                    isSubsq = false;
                    break;
                }
                else
                {
                    xList.Remove(partY[i]);
                }
            }

            return isSubsq;
        }

        static int maxLength(int[] a, int k)
        {
            int longestSubarrayLength = 0;
            int sum = 0;
            int startingIndex = 0;
            List<int> subArray = new List<int>();

            int i = 0;
            while (i < a.Length)
            {
                if (sum + a[i] <= k)
                {
                    sum += a[i];
                    subArray.Add(a[i]);
                }
                else
                {
                    longestSubarrayLength = subArray.Count > longestSubarrayLength ? subArray.Count : longestSubarrayLength;
                    sum -= a[startingIndex];
                    subArray.RemoveAt(startingIndex);
                    startingIndex = startingIndex + 1;
                }
                i = i + 1;
            }

            if (subArray.Count > 0)
            {
                longestSubarrayLength = subArray.Count > longestSubarrayLength ? subArray.Count : longestSubarrayLength;
            }

            return longestSubarrayLength;
        }

        private static void RunStrings()
        {
            //PrettyJSON.Run();
            //AddBinaryStrings.Run();
            //SetMatrixZeros.Run();
            //JustifyText.Run();
            //LongestCommonPrefix.Run();
            //LastWordLength.Run();
            //ReverseAString.Run();
            //PalindromeString.Run();
        }
        private static void RunArrays()
        {
            //SpiralOderII.Run();
            //PascalTriangle.Run();
            //AddOneToNumber.Run();

            //Yet to complete
            //RotateMatrix.Run();
        }

        private static void RunCalibrationOne()
        {
            //Winner.Run();
            //Braces.Run();
            //ArrangingCoins.Run();
            //DegreeArray.Run();
        }

        private static void RunCheckpoints()
        {
            PrettyPrint.Run();
            NumRange.Run();
            NextGreater.Run();
            LongestConsecutiveSequence.Run();
        }
    }
}
