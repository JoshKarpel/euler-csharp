using System;

namespace ProjectEuler.solvers {
    public class P006 {
        public static long Solve() {
            long sumOfSquares = 0;
            for (long i = 1; i <= 100; i++) {
                sumOfSquares += (i * i);
            }

            var squareOfSum = (long) Math.Pow(100 * 101 / 2, 2);

            return squareOfSum - sumOfSquares;
        }
    }
}
