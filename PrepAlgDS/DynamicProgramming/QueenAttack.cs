using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class QueenAttack
    {
        public static void Run()
        {
        }

        public static List<List<int>> queenAttack(List<string> A)
        {
            List<List<int>> res = new List<List<int>>();

            for (int i = 0; i < A.Count; i++)
            {
                res.Add(new List<int>());
                for (int j = 0; j < A[i].Length; j++)
                {
                    res[i].Add(0);
                }
            }

            fillHorizontal(A, res);
            fillVertical(A, res);
            fillDiagonal(A, res);
            fillDiagonal2(A, res);
            return res;
        }

        private static void fillHorizontal(List<string> A, List<List<int>> res)
        {
            for (int i = 0; i < A.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < A[0].Length; j++)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }

            for (int i = 0; i < A.Count; i++)
            {
                bool flag = false;
                for (int j = A[0].Length - 1; j >= 0; j--)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }
        }

        private static void fillVertical(List<string> A, List<List<int>> res)
        {
            for (int j = 0; j < A[0].Length; j++)
            {
                bool flag = false;
                for (int i = 0; i < A.Count; i++)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }

            for (int j = 0; j < A[0].Length; j++)
            {
                bool flag = false;
                for (int i = A.Count - 1; i >= 0; i--)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }
        }

        private static void fillDiagonal(List<string> A, List<List<int>> res)
        {
            for (int k = 0; k < A[0].Length; k++)
            {
                bool flag = false;
                for (int i = 0, j = k; i < A.Count && j >= 0; i++, j--)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }

            for (int k = 1; k < A.Count; k++)
            {
                bool flag = false;
                for (int i = k, j = A[0].Length - 1; i < A.Count && j >= 0; i++, j--)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }

            for (int k = 0; k < A.Count; k++)
            {
                bool flag = false;
                for (int i = k, j = 0; i >= 0 && j < A[0].Length; i--, j++)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }

            for (int k = 1; k < A[0].Length; k++)
            {
                bool flag = false;
                for (int i = A.Count - 1, j = k; i >= 0 && j < A[0].Length; i--, j++)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }
        }

        private static void fillDiagonal2(List<string> A, List<List<int>> res)
        {
            for (int k = 0; k < A[0].Length; k++)
            {
                bool flag = false;
                for (int i = 0, j = k; i < A.Count && j < A[0].Length; i++, j++)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }

            for (int k = 1; k < A.Count; k++)
            {
                bool flag = false;
                for (int i = k, j = 0; i < A.Count && j < A[0].Length; i++, j++)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }

            for (int k = 0; k < A[0].Length; k++)
            {
                bool flag = false;
                for (int i = A.Count - 1, j = k; i >= 0 && j >= 0; i--, j--)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }

            for (int k = 0; k < A.Count - 1; k++)
            {
                bool flag = false;
                for (int i = k, j = A[0].Length - 1; i >= 0 && j >= 0; i--, j--)
                {
                    if (flag)
                    {
                        res[i][j]++;
                    }

                    if (A[i][j] == '1')
                    {
                        flag = true;
                    }
                }
            }
        }
    }
}
