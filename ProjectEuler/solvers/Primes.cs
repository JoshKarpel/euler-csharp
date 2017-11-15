using System.Collections.Generic;

namespace ProjectEuler.solvers {
    public static class Primes {
        public static List<ulong> PrimeFactorization(ulong n) {
            var factors = new List<ulong>();

            while (n % 2 == 0) {
                factors.Add(2);
                n /= 2;
            }

            ulong divisor = 3;

            while (n > 1) {
                if (n % divisor == 0) {
                    factors.Add(divisor);
                    n /= divisor;
                }
                else {
                    divisor += 2;
                }
            }

            return factors;
        }
    }
}