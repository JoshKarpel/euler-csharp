using System;

namespace ProjectEuler.solvers {
    public class P009 {
        public static long Solve() {
            const ulong target = 1000;
            
            for (ulong a = 0; a <= target; a++) {
                for (ulong b = 0; b < a; b++) {
                    var c = target - b - a;

                    if (a + b + c == target && EulerMath.IsPythagoreanTriplet(a, b, c)) {
                        return (long) (a * b * c);
                    }
                }
            }

            return 0;
        }
    }
}
