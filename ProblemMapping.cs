using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class ProblemMapping
    {
        public static Dictionary<int, IProblem> map = new Dictionary<int, IProblem>
        {
            {1, new Problems1to50.ProblemOne()},
            {2, new Problems1to50.Problem2.ProblemTwo()}
        };
    }
}
