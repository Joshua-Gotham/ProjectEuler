using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems1to50
{
    public class ProblemOne : IProblem
    {
        public string DateSolved()
        {
            return "1/13/2017";
        }

        public string Difficulty()
        {
            return "Easy";
        }

        public bool Solved()
        {
            return true;
        }

        public string SolveProblem()
        {
            int returnInt = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) returnInt += i;
            }
            return returnInt.ToString();
        }
    }
}
