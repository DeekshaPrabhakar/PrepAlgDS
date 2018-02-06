using PrepAlgDS.Arrays;
using PrepAlgDS.BinarySearch;
using PrepAlgDS.CalibrationOne;
using PrepAlgDS.Checkpoints;
using PrepAlgDS.DynamicProgramming;
using PrepAlgDS.Graphs;
using PrepAlgDS.HashTables;
using PrepAlgDS.Heaps;
using PrepAlgDS.LinkedLists;
using PrepAlgDS.Recursion;
using PrepAlgDS.Strings;
using PrepAlgDS.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunCalibrationThree();
            //RunBSTrees();
            //RunTrees();
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
            //RunCalibrationFour();
            //RunGraphs();
            //RunDynamicProgramming();
            // Console.WriteLine(degreeOfArray(new int[] { 1, 0, 1 }));
            //RunCalibrationFive();
            RunCalibrationSix();
            Console.ReadLine();
        }

        static void RunCalibrationSix()
        {
            //fiveOne();
            //fiveTwo();
            //fiveThree();

            int i = 0;
            int j = 0;
            string s = "ababac";

            while (i < s.Length)
            {
                if (s[i] == s[j] && i != j)
                {
                    if (s.Substring(0, s.Length - i) == s.Substring(j, s.Length - i))
                    {

                    }
                }
                else
                {
                    j = j + 1;
                }

            }
        }

        static void fiveThree()
        {
            int res;
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int bundleQuantities_size = 0;
            bundleQuantities_size = Convert.ToInt32(Console.ReadLine());
            int[] bundleQuantities = new int[bundleQuantities_size];
            int bundleQuantities_item;
            for (int bundleQuantities_i = 0; bundleQuantities_i < bundleQuantities_size; bundleQuantities_i++)
            {
                bundleQuantities_item = Convert.ToInt32(Console.ReadLine());
                bundleQuantities[bundleQuantities_i] = bundleQuantities_item;
            }

            int bundleCosts_size = 0;
            bundleCosts_size = Convert.ToInt32(Console.ReadLine());
            int[] bundleCosts = new int[bundleCosts_size];
            int bundleCosts_item;
            for (int bundleCosts_i = 0; bundleCosts_i < bundleCosts_size; bundleCosts_i++)
            {
                bundleCosts_item = Convert.ToInt32(Console.ReadLine());
                bundleCosts[bundleCosts_i] = bundleCosts_item;
            }

            res = budgetShopping(n, bundleQuantities, bundleCosts);
        }

        static int budgetShopping(int n, int[] bundleQuantities, int[] bundleCosts)
        {
            int books = 0;



            return books;
        }

        static void fiveTwo()
        {

            int res;
            string s;
            s = Console.ReadLine();

            int minLength;
            minLength = Convert.ToInt32(Console.ReadLine());

            int maxLength;
            maxLength = Convert.ToInt32(Console.ReadLine());

            int maxUnique;
            maxUnique = Convert.ToInt32(Console.ReadLine());

            res = getMaxOccurrences(s, minLength, maxLength, maxUnique);
        }


        static int getMaxOccurrences(string s, int minLength, int maxLength, int maxUnique)
        {
            int max = 0;
            Dictionary<string, int> repStrCount = new Dictionary<string, int>();
            List<char> chArray = new List<char>();
            int i = 0;
            int j = 0;

            while (i < s.Length)
            {
                if (s[i] == s[j] && i != j)
                {
                    if(s.Substring(0,s.Length-i) == s.Substring(j,s.Length -i))
                    {

                    }
                }
                else
                {
                    j = j + 1;
                }

            }

                return max;
        }
        
        static void fiveOne()
        {
            int arr_rows = 0;
            int arr_cols = 0;
            arr_rows = Convert.ToInt32(Console.ReadLine());
            arr_cols = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[arr_rows][];
            for (int arr_i = 0; arr_i < arr_rows; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            countNumbers(arr);
        }

        static void countNumbers(int[][] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                int[] row = arr[i];
                Console.WriteLine(calculateRow(row[0], row[1]));
            }
        }

        static Int64 calculateRow(int n, int m)
        {
            Dictionary<int, bool> numFavDict = new Dictionary<int, bool>();
            //bool[] numFavDict = new bool[m];
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (!numFavDict.ContainsKey(i))
                {
                    numFavDict.Add(i, isNumberFavorite(i));
                }

                if (numFavDict[i])
                {
                    count++;
                }
            }
            return count;
        }

        static bool isNumberFavorite(int num)
        {
            bool isFav = true;
            bool[] digitsDict = new bool[10];

            while(num != 0)
            {
                if(digitsDict[num%10] == true)
                {
                    return false;
                }
                digitsDict[num % 10] = true;
                num = num / 10;
            }

            return isFav;
        }


        //static bool isNumberFavorite(int num)
        //{
        //    bool isFav = true;
        //    char[] numArray = num.ToString().ToCharArray();
        //    Dictionary<char, int> digitDict = new Dictionary<char, int>();

        //    foreach (char s in numArray)
        //    {
        //        if (digitDict.ContainsKey(s))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            digitDict.Add(s, 1);
        //        }
        //    }

        //    return isFav;
        //}

        static void RunCalibrationFive()
        {
            //Console.WriteLine(canReach(1,4,5,9));
            //Console.WriteLine(canReach(1, 2, 2, 1));
            int[] res;
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int queryType_size = 0;
            queryType_size = Convert.ToInt32(Console.ReadLine());
            string[] queryType = new string[queryType_size];
            string queryType_item;
            for (int queryType_i = 0; queryType_i < queryType_size; queryType_i++)
            {
                queryType_item = Console.ReadLine();
                queryType[queryType_i] = queryType_item;
            }

            int students1_size = 0;
            students1_size = Convert.ToInt32(Console.ReadLine());
            int[] students1 = new int[students1_size];
            int students1_item;
            for (int students1_i = 0; students1_i < students1_size; students1_i++)
            {
                students1_item = Convert.ToInt32(Console.ReadLine());
                students1[students1_i] = students1_item;
            }

            int students2_size = 0;
            students2_size = Convert.ToInt32(Console.ReadLine());
            int[] students2 = new int[students2_size];
            int students2_item;
            for (int students2_i = 0; students2_i < students2_size; students2_i++)
            {
                students2_item = Convert.ToInt32(Console.ReadLine());
                students2[students2_i] = students2_item;
            }

            res = getTheGroups(n, queryType, students1, students2);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }

        public class Student
        {
            public int id;
            public List<int> friends;//ID's
            public Student(int id)
            {
                this.id = id;
                this.friends = new List<int>();
            }
        }
        static int[] getTheGroups(int n, string[] queryType, int[] students1, int[] students2)
        {
            List<int> arr = new List<int>();
            Dictionary<int, List<int>> studentIDFriends = new Dictionary<int, List<int>>();
            
            for (int i = 1; i <= n; i++)
            {
                studentIDFriends.Add(i, new List<int>(new int[] { i }));
            }

           
            for (int i = 0; i < queryType.Length; i++)
            {
                if (queryType[i] == "Friend" && students1.Length > 0)
                {
                    int grouptoadd = students1[0];
                    for (int j = 1; j < students1.Length; j++)
                    {
                        studentIDFriends[grouptoadd].Add(students1[j]);
                        studentIDFriends.Remove(students1[j]);
                    }
                }
                else if(queryType[i] == "Total")
                {
                    int count = 0;
                    foreach (int studentID in students2)
                    {
                        foreach(List<int> friends in studentIDFriends.Values)
                        {
                            if(friends.Contains(studentID))
                            {
                                count += friends.Count;
                                break;
                            }
                        }                       
                    }
                   
                    arr.Add(count);
                }
            }
            
            return arr.ToArray();
        }

        class Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static string canReach(int x1, int y1, int x2, int y2)
        {
             Queue<Point> toExplore = new Queue<Point>();
            toExplore.Enqueue(new Point(x1, y1));

            while (toExplore.Count > 0)
            {
                Point p = toExplore.Dequeue();

                if (p.x == x2 && p.y == y2)
                {
                    return "Yes";
                }

                if (p.x > x2 || p.y > y2)
                {
                    return "No";
                }

                if (x1 < x2)
                {
                    x1 = x1 + y1;
                }
                else if (y1 < y2)
                {
                    y1 = x1 + y1;
                }
                toExplore.Enqueue(new Point(x1, y1));
            }
            return "No";
        }
        static void RunDynamicProgramming()
        {
            //Stairs.Run();
            //Decode.Run();
            //JumpGame.Run();
            //LongestParenthesesValid.Run();
            //Fibonacci.Run();
            //RepeatingSubSequence.Run();
            //LongestIncreasingSubSequence.Run();
            WordBreakII.Run();
        }
        static void RunGraphs()
        {
            //SteppingNumbers.Run();
            //CloneGraph.Run();
            //WordLadder.Run();
            FinishPreReq.Run();
            PrimeSmallestSequence.Run();
        }
        static int degreeOfArray(int[] arr)
        {
            int minimumSubArrayCount = int.MaxValue;
            if (arr.Length == 0)
            {
                return 0;
            }

            int degree = 0;
            Dictionary<int, int> elementCountDict = new Dictionary<int, int>();
            Dictionary<int, int> elementStartIndexDict = new Dictionary<int, int>();
            Dictionary<int, int> elementEndIndexDict = new Dictionary<int, int>();

            for (int index = 0; index < arr.Length; index++)
            {
                int el = arr[index];
                if (elementCountDict.ContainsKey(el))
                {
                    elementCountDict[el] = elementCountDict[el] + 1;
                    elementEndIndexDict[el] = index;
                }
                else
                {
                    elementCountDict.Add(el, 1);
                    elementStartIndexDict.Add(el, index);
                    elementEndIndexDict.Add(el, index);
                }
                degree = elementCountDict[el] > degree ? elementCountDict[el] : degree;
            }

            foreach(KeyValuePair<int,int> kv in elementCountDict)
            {
                if(kv.Value == degree)
                {
                    int subArrayCount = (elementEndIndexDict[kv.Key] - elementStartIndexDict[kv.Key]) + 1;
                    minimumSubArrayCount = subArrayCount < minimumSubArrayCount ? subArrayCount : minimumSubArrayCount;
                }
            }

            return minimumSubArrayCount;
        }


        private static void RunCalibrationFour()
        {
            //Console.WriteLine(isPossible(1, 4, 5, 9));
            //Console.WriteLine(isPossible(1, 2, 3, 6));
            //possible(1, 4, 5, 9);
            counterGame("6");
        }


        static void counterGame(string test)
        {
            
                ulong N = 0;

                if (ulong.TryParse(test, out N) == false)
                {
                    N = 0;
                }
                if (N > 0)
                {
                    bool isLouiseplaying = true;
                    ulong counter = N;

                    while (counter != 1)
                    {
                        if (isPowerofTwo(counter))
                        {
                            counter = counter / 2;
                        }
                        else
                        {
                            counter = counter - largestPowerLessThan(counter);
                        }
                        isLouiseplaying = !isLouiseplaying;
                    }

                    if (isLouiseplaying)
                    {
                        Console.WriteLine("Richard");
                    }
                    else
                    {
                        Console.WriteLine("Louise");
                    }
                }
            
        }

        static ulong largestPowerLessThan(ulong N)
        {
            ulong n = IntergerSquareroot(N);
            return (n * n);
        }

        private static ulong IntergerSquareroot(ulong A)
        {
            ulong left = 0, right = A;//for 25
            //save interval for 25 in left and right initially 0 - 25; take mid 12 if 12*12 = 144
            while (left <= right)
            {
                ulong mid = left + ((right - left) / 2);
                ulong midSquared = mid * mid;
                if (midSquared <= A)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return (ulong)left - 1;
        }

        static bool isPowerofTwo(ulong N)
        {
            return ((N & (N - 1)) == 0);
        }

        static string isPossible(int a, int b, int c, int d)
        {
            if (possible(a, b, c, d))
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        static bool possible(int a, int b, int c, int d)
        {
           
            if(a==c && b ==d)
            {
                return true;
            }

            if(a>c || b > d)
            {
                return false;
            }
            //choose - explore - unchoose
            while (!(a == c && b == d))
            {
                int tempa = a;
                int tempb = b;
                if (a < c)
                {
                    a = a + b;
                }
                else if (b < d)
                {
                    b = a + b;
                }
                return possible(a, b, c, d);
            }
            return false;
        }

        static void pascalTriangle(int k)
        {
            StringBuilder sb = new StringBuilder();
            for (int n = 0; n < k; n++)
            {
                sb = new StringBuilder();
                for (int r = 0; r <= n; r++)
                {
                    sb.Append(getPascalTraingleValue(n, r).ToString() + ' ');
                }
                string str = sb.ToString();
                Console.WriteLine(str.Substring(0, str.Length - 1));
            }
        }

        static Int64 getPascalTraingleValue(int n, int r)
        {           
            if (n == 0 || r == 0)
            {
                return 1;
            }           
            return (factorial(n) / (factorial(r) * factorial(n - r)));
        }

        static Int64 factorial(int k)
        {
            if (k == 1 || k == 0)
            {
                return 1;
            }
            return k * factorial(k - 1);
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
