using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace ProjectEuler.Problems1to50.Problem2
{
    public class ProblemTwo : IProblem
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
            return Observable.Generate(Tuple.Create(1, 2),
                                     t => t.Item1 < 4000000,
                                     t => Tuple.Create(t.Item2, t.Item1 + t.Item2),
                                     t => t.Item1)
                                     .Where(t => t % 2 == 0)
                                     .Sum()
                                     .ToEnumerable()
                                     .ToList()[0]
                                     .ToString();
        }
    }
}
