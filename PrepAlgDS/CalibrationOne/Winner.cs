using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.CalibrationOne
{
    class Winner
    {
        public static void Run()
        {
            string res;
            int andrea_size = 0;
            andrea_size = Convert.ToInt32(Console.ReadLine());
            int[] andrea = new int[andrea_size];
            int andrea_item;
            for (int andrea_i = 0; andrea_i < andrea_size; andrea_i++)
            {
                andrea_item = Convert.ToInt32(Console.ReadLine());
                andrea[andrea_i] = andrea_item;
            }

            int maria_size = 0;
            maria_size = Convert.ToInt32(Console.ReadLine());
            int[] maria = new int[maria_size];
            int maria_item;
            for (int maria_i = 0; maria_i < maria_size; maria_i++)
            {
                maria_item = Convert.ToInt32(Console.ReadLine());
                maria[maria_i] = maria_item;
            }

            string s;
            s = Console.ReadLine();

            res = winner(andrea, maria, s);
            Console.WriteLine("the winner is: ");
            Console.WriteLine(res);
        }

        public static string winner(int[] andrea, int[] maria, string s)
        {
            string winning = "";
            List<int> noOfMoves = new List<int>();
            int n = andrea.Length;
            int i = (s == "Even") ? 0 : 1;
            int andreaPoints = 0;
            int mariaPoints = 0;


            while (i < andrea.Length)
            {
                noOfMoves.Add(i);
                i = i + 2;
            }

            i = 0;
            int move = 0;

            while(i<noOfMoves.Count)
            {
                move = noOfMoves[i];
                andreaPoints += andrea[move] - maria[move];
                mariaPoints += maria[move] - andrea[move];
                i++;
            }

            if (andreaPoints == mariaPoints)
            {
                return "Tie";
            }

            winning = andreaPoints > mariaPoints ? "Andrea" : "Maria";

            return winning;
        }
    }
}
