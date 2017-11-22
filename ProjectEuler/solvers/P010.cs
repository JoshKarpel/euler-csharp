using System;

namespace ProjectEuler.solvers {
    public class P010 {
        public static long Solve() {
            ulong acc = 0;
            foreach (var x in EulerMath.SieveOfEratosthenes(2000000)) {
                acc += x;
            }

            return (long) acc;
        }
    }
}
