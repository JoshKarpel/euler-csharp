﻿using System.Linq;

namespace ProjectEuler.solvers {
    public static class P003 {
        public static long Solve() {
            var factors = Primes.PrimeFactorization(600851475143);

            return (long) factors.Last();
        }
    }
}