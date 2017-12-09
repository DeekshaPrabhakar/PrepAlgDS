using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.HashTables
{
    class Fraction
    {
        public static void Run()
        {
            //Console.WriteLine(fractionRep(1, 2));// 0.5 
            //Console.WriteLine(fractionRep(2, 1));// 2
            //Console.WriteLine(fractionRep(2, 3));// 0.(6)
            //Console.WriteLine(fractionRep(-1, 2));
            Console.WriteLine(fractionRep(-2147483648, -1));
        }

        private static string fractionRep(int  A, int B)
        {
            StringBuilder sb = new StringBuilder();

            if(B == 0 )
            {
                return "NaN";
            }

            if(A == 0)
            {
                return "0";
            }

            bool isNegative = false;

            if(A<0 || B <0)
            {
                if((A<0 && B > 0) || (B< 0 &&  A > 0))
                {
                    isNegative = true;
                }
            }

            Int64 num =  A < 0 ? Int64.Parse(A.ToString().Substring(1)) : A;
            Int64 den = B < 0 ? Int64.Parse(B.ToString().Substring(1)) : B;

            Int64 intPart = num / den;
            sb.Append(intPart.ToString());

            long remainder = (num % den) * 10;

            if (remainder == 0)
            {
                if (isNegative)
                {
                    return "-" + sb.ToString();
                }
                else
                {
                    return sb.ToString();
                }
            }

            sb.Append(".");
            Dictionary<long, int> remainderDict = new Dictionary<long, int>();
            while (remainder != 0)
            {
                if (remainderDict.ContainsKey(remainder))
                {
                    int pos = int.Parse(remainderDict[remainder].ToString());
                    string result = sb.ToString();
                    String part1 = result.Substring(0, pos);
                    String part2 = result.Substring(pos);
                    sb = new StringBuilder();
                    sb.Append(part1 + "(" + part2 + ")");
                    if (isNegative)
                    {
                        return "-" + sb.ToString();
                    }
                    else
                    {
                        return sb.ToString();
                    }
                }
                sb.Append((remainder / den).ToString());
                remainderDict.Add(remainder, sb.Length - 1);
                remainder = (remainder % den) * 10;
            }

            if (isNegative)
            {
                return "-" + sb.ToString();
            }
            else
            {
                return sb.ToString();
            }
           

            return sb.ToString();
        }
    }
}
