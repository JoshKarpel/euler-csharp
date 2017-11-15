namespace ProjectEuler.solvers {
    public static class P001 {
        public static long Solve() {
            long acc = 0;
            for (long n = 0; n < 1000; n++) {
                if (n % 3 == 0 || n % 5 == 0) {
                    acc += n;
                }
            }

            return acc;
        }
    }
}