using System;
using System.Collections.Generic;

namespace ProjectEuler {
    internal static class ProjectEuler {
        public static void Main(string[] args) {
            var solver_dictionary = GetSolverDictionary();

            Func<long> solver;
            if (!solver_dictionary.TryGetValue(args[0], out solver)) {
                var not_found_msg = $"Couldn't find a solver for {args[0]}";
                Console.WriteLine(not_found_msg);
                System.Environment.Exit(0);
            }
            var answer = solver();

            var solved_msg = $"Answer: {answer}";
            Console.WriteLine(solved_msg);
        }

        private static Dictionary<string, Func<long>> GetSolverDictionary() {
            var solver_dictionary = new Dictionary<string, Func<long>>();

            solver_dictionary.Add("001", solvers.P001.Solve);
            solver_dictionary.Add("002", solvers.P002.Solve);
            solver_dictionary.Add("003", solvers.P003.Solve);

            return solver_dictionary;
        }
    }
}