using System;

namespace ProjectEuler.solvers {
    public class p001 {
        public static UInt64 solve() {
            UInt64 acc = 0;
            for (UInt64 n = 0; n < 1000; n++) {
                if (n % 3 == 0 || n % 5 == 0) {
                    acc += n;
                }
            }

            return acc;
        }
    }
}