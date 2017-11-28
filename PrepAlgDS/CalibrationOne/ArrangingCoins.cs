using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.CalibrationOne
{
    class ArrangingCoins
    {
         public static void Run()
        {
            int coins_size = 0;
            coins_size = Convert.ToInt32(Console.ReadLine());
            long[] coins = new long[coins_size];
            long coins_item;
            for (int coins_i = 0; coins_i < coins_size; coins_i++)
            {
                coins_item = Convert.ToInt64(Console.ReadLine());
                coins[coins_i] = coins_item;
            }

            arrangeCoins(coins);           
        }

         public static void arrangeCoins(long[] coins)
         {
             for (int res_i = 0; res_i < coins.Length; res_i++)
             {
                 Console.WriteLine(arrangeCoinInput(coins[res_i]));
             }
         }

         private static long arrangeCoinInput(long n)
         {
             long result = 0;
             long coins = n;
             for (int i = 1; i <= n; i++)
             {
                 if (i <= coins)
                 {
                     result++;
                     coins = coins - i;
                 }
                 else
                 {
                     break;
                 }
             }
             return result;
         }
    }
}
