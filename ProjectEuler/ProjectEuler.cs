using System;
using System.Collections.Generic;

namespace ProjectEuler {
    internal static class ProjectEuler {
        public static void Main(string[] args) {
            var solverDictionary = GetSolverDictionary();

            if (!solverDictionary.TryGetValue(args[0], out var solver)) {
                var notFoundMsg = $"Couldn't find a solver for {args[0]}";
                Console.WriteLine(notFoundMsg);
                Environment.Exit(0);
            }
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var answer = solver();
            stopwatch.Stop();

            var solvedMsg = $"Answer: {answer} | Elapsed Time: {((float) stopwatch.ElapsedMilliseconds / 1000)} seconds";
            Console.WriteLine(solvedMsg);
        }

        private static Dictionary<string, Func<long>> GetSolverDictionary() {
            var solverDictionary = new Dictionary<string, Func<long>> {
                {"001", solvers.P001.Solve},
                {"002", solvers.P002.Solve},
                {"003", solvers.P003.Solve},
                {"005", solvers.P005.Solve},
                {"006", solvers.P006.Solve},
                {"009", solvers.P009.Solve},
                {"010", solvers.P010.Solve},
            };


            return solverDictionary;
        }
    }
}
