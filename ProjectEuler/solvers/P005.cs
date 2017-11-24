using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.solvers {
    public class P005 {
        public static long Solve() {
            var factorCounters = GetFactorizationCounters(20);
            var targetFactorization = ConstructTargetFactorization(factorCounters);

            return (long) EulerMath.PrimeFactorizationCounterProduct(targetFactorization);
        }

        private static Dictionary<ulong, ulong> ConstructTargetFactorization(IEnumerable<Dictionary<ulong, ulong>> factorCounters) {
            var targetFactorization = new Dictionary<ulong, ulong>();

            foreach (var counter in factorCounters) {
                foreach (var pair in counter) {
                    if (targetFactorization.TryGetValue(pair.Key, out var currentCount)) {
                        targetFactorization[pair.Key] = Math.Max(currentCount, pair.Value);
                    }
                    else {
                        targetFactorization[pair.Key] = pair.Value;
                    }
                }
            }

            return targetFactorization;
        }

        private static IEnumerable<Dictionary<ulong, ulong>> GetFactorizationCounters(ulong n) {
            var factorizations = new List<Dictionary<ulong, ulong>>();

            foreach (ulong x in Enumerable.Range(1, 21)) {
                var factorCounter = Utils.MakeCounter(EulerMath.PrimeFactorization(x));
                factorizations.Add(factorCounter);
            }

            return factorizations;
        }
    }
}
