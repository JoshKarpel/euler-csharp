using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.solvers {
    public static class EulerMath {
        public static IEnumerable<ulong> PrimeFactorization(ulong n) {
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

        public static ulong PrimeFactorizationCounterProduct(Dictionary<ulong, ulong> factorCounter) {
            ulong result = 1;

            foreach (var pair in factorCounter) {
                result *= (ulong) Math.Pow(pair.Key, pair.Value);
            }

            return result;
        }

        public static IEnumerable<ulong> SieveOfEratosthenes(int n) {
            var sieve = new BitArray(n, true) {
                [0] = false,
                [1] = false
            };

            var primes = new List<ulong>();

            for (ulong p = 2; p < (ulong) n; p++) {
                if (sieve[(int) p]) {
                    primes.Add(p);
                    var x = p * p;

                    while (x < (ulong) n) {
                        sieve[(int) x] = false;
                        x += p;
                    }
                }
            }


            return primes;
        }

        public static bool IsPythagoreanTriplet(ulong a, ulong b, ulong c) {
            var triplet = new List<ulong>(new ulong[] {a, b, c});
            triplet.Sort();


            return (ulong) Math.Pow(triplet[0], 2) + (ulong) Math.Pow(triplet[1], 2) == (ulong) Math.Pow(triplet[2], 2);
        }
    }
}
