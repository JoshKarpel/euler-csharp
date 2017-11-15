using System;
using System.Collections.Generic;

namespace ProjectEuler {
    internal static class ProjectEuler {
        public static void Main(string[] args) {
            var solver_dictionary = GetSolverDictionary();

            Func<long> solver;
            if (!solver_dictionary.TryGetValue(args[0], out solver)) {
                string not_found_msg = String.Format("Couldn't find a solver for {0}", args[0]);
                Console.WriteLine(not_found_msg);
                System.Environment.Exit(0);
            }
            var answer = solver();

            var solved_msg = String.Format("Answer: {0}", answer);
            Console.WriteLine(solved_msg);
        }

        public static Dictionary<string, Func<long>> GetSolverDictionary() {
            var solver_dictionary = new Dictionary<string, Func<long>>();

            solver_dictionary.Add("001", solvers.P001.Solve);

            return solver_dictionary;
        }
    }
}