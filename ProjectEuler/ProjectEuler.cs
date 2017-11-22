using System;
using System.Collections.Generic;

namespace ProjectEuler {
    internal static class ProjectEuler {
        public static void Main(string[] args) {
            var solverDictionary = GetSolverDictionary();

            Func<long> solver;
            if (!solverDictionary.TryGetValue(args[0], out solver)) {
                var notFoundMsg = $"Couldn't find a solver for {args[0]}";
                Console.WriteLine(notFoundMsg);
                Environment.Exit(0);
            }
            var answer = solver();

            var solvedMsg = $"Answer: {answer}";
            Console.WriteLine(solvedMsg);
        }

        private static Dictionary<string, Func<long>> GetSolverDictionary() {
            var solverDictionary = new Dictionary<string, Func<long>> {
                {"001", solvers.P001.Solve},
                {"002", solvers.P002.Solve},
                {"003", solvers.P003.Solve},
                {"005", solvers.P005.Solve},
                {"010", solvers.P010.Solve},
            };


            return solverDictionary;
        }
    }
}
