using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.HashTables
{
    class TwoSum
    {
        public class Node : IComparable<Node>
        {
            public int index1;
            public int index2;

            public Node(int ind1, int ind2)
            {
                this.index1 = ind1;
                this.index2 = ind2;
            }

            public int CompareTo(Node other)
            {
                if (this.index2 < other.index2)
                    return -1;
                if (this.index2 > other.index2)
                    return 1;
                return this.index1.CompareTo(other.index1);
            }
        }

        public static void Run()
        {
            Console.WriteLine("Hashing: TwoSum for [4, 7, -4, 2, 2, 2, 3, -5, -3, 9, -4, 9, -7, 7, -1, 9, 9, 4, 1, -4, -2, 3, -3, -5, 4, -7, 7, 9, -4, 4, -8] with target -3");
            List<int> listOne = new List<int>(new int[] { 4, 7, -4, 2, 2, 2, 3, -5, -3, 9, -4, 9, -7, 7, -1, 9, 9, 4, 1, -4, -2, 3, -3, -5, 4, -7, 7, 9, -4, 4, -8 });
            Util.DisplayList(twoSum(listOne, -3));
            Console.WriteLine("");

            Console.WriteLine("Hashing: TwoSum for [1, 1, 1 ] with target 2");
            listOne = new List<int>(new int[] { 1, 1, 1 });
            Util.DisplayList(twoSum(listOne, 2));
            Console.WriteLine("");

            Console.WriteLine("Hashing: TwoSum for [2, 7, 11, 15] with target 9");
            listOne = new List<int>(new int[] { 2, 7, 11, 15 });
            Util.DisplayList(twoSum(listOne, 9));
            Console.WriteLine("");
        }
        private static List<int> twoSum(List<int> A, int B)
        {
            Hashtable hashMap = new Hashtable();
            List<int> resultList = new List<int>();
            List<Node> resultIndexesList = new List<Node>();

            int sum = B;
            int diff;
            int size = A.Count;
            int num;
            int index;

            //go through array from last
            for (int i = size - 1; i >= 0; i--)
            {
                num = A[i];
                diff = sum - num;

                //if difference found for current number,store current index and difference index
                if (hashMap.ContainsKey(diff))
                {
                    index = int.Parse(hashMap[diff].ToString());
                    resultIndexesList.Add(new Node(i + 1, index + 1));
                }

                //store input characters and index in hashtable
                if (!hashMap.ContainsKey(num))
                {
                    hashMap.Add(num, i);//1,1
                }
                else
                {//update index if number founnd 
                    hashMap[num] = i;//1,0
                }
            }

            if (resultIndexesList.Count > 0)
            {
                resultIndexesList.Sort();//sort based on index1 < index2 and for for same index2 minimum index1
                resultList.Add(resultIndexesList[0].index1);
                resultList.Add(resultIndexesList[0].index2);
            }

            return resultList;
        }
    }

}
