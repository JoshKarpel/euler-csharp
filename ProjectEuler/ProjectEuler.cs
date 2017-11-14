using System;
using System.Collections.Generic;

using ProjectEuler.solvers;

namespace ProjectEuler {
    internal class Solver {
        public static void Main(string[] args) {
            Dictionary<string, Func<UInt64>> solver_dictionary = GetSolverDictionary();

            Func<UInt64> solver;
            if (!solver_dictionary.TryGetValue(args[0], out solver)) {
                string not_found_msg = String.Format("Couldn't find a solver for {0}", args[0]);
                Console.WriteLine(not_found_msg);
                System.Environment.Exit(0);
            }
            UInt64 answer = solver();

            string solved_msg = String.Format("Answer: {0}", answer);
            Console.WriteLine(solved_msg);
        }

        public static Dictionary<string, Func<UInt64>> GetSolverDictionary() {
            Dictionary<string, Func<UInt64>> solver_dictionary = new Dictionary<string, Func<UInt64>>();

            solver_dictionary.Add("001", solvers.p001.solve);

            return solver_dictionary;
        }
    }
}