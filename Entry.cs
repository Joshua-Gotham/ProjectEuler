using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Entry
    {
        static IProblem _problem;
        static void Main(string[] args)
        {
            Console.WriteLine("Please input problem number");
            try
            {
                int problemNum = Int32.Parse(Console.ReadLine());
                if (!ProblemMapping.map.ContainsKey(problemNum)) throw new IndexOutOfRangeException("Problem number out of range.");
                else _problem = ProblemMapping.map[problemNum];
                if (_problem.Solved()) Console.WriteLine("Answer: {0}, Difficulty: {1}, Date Completed: {2}", _problem.SolveProblem(), _problem.Difficulty(), _problem.DateSolved());
                else Console.WriteLine("Problem Not solved");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
            
        }
    }
}
