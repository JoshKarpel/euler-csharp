using System.Collections.Generic;

namespace ProjectEuler.solvers {
    public static class Utils {
        public static Dictionary<T, ulong> MakeCounter<T>(IEnumerable<T> input) {
            var counter = new Dictionary<T, ulong>();

            foreach (var element in input) {
                ulong count;
                if (!counter.TryGetValue(element, out count)) {
                    count = 0;
                }
                counter[element] = count + 1;
            }

            return counter;
        }
    }
}
