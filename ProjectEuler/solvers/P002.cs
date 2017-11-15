using System;


namespace ProjectEuler.solvers {
    public static class P002 {
        public static long Solve() {
            ulong fibPrev = 1;
            ulong fibCurr = 1;
            ulong acc = 0;

            while (fibCurr < 4000000) {
                if (fibCurr % 2 == 0) {
                    acc += fibCurr;
                }

                var fibNext = fibCurr + fibPrev;
                fibPrev = fibCurr;
                fibCurr = fibNext;
            }

            return (long) acc;
        }
    }
}