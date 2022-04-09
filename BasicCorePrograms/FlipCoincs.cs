using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoincs
    {
        public static void Flip()
        {
            int No_Of_Times, Counttail = 0, Counthead = 0;
            Console.WriteLine("Enter the number of times to flip");
            No_Of_Times = int.Parse(Console.ReadLine());
            for (int start = 0; start < No_Of_Times; start++)
            {
                Random random = new Random();
                double flip = random.NextDouble();
                if (flip < 0.5)
                    Counttail++;
                else
                    Counthead++;
            }
            Console.WriteLine("Total no of Tail: {0}", Counttail);
            Console.WriteLine("Total no of Head: {0}", Counthead);

            double headPecent = (double)Counthead / No_Of_Times * 100;
            double tailPercent = (double)Counttail / No_Of_Times * 100;
            Console.WriteLine("Percentage of tail: {0}", tailPercent);
            Console.WriteLine("Percentage of head: {0}",headPecent);
        }
    }
}



