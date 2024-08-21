using System;
using System.Collections.Generic;

namespace _09_LINQ_Any {
    internal class Program {
        static void Main() {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var res = ints.MyAny(t => t > 10);

            Console.ReadLine();
        }
    }

    static class MyEnumerable {
        public static bool MyAny<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) {
            foreach (var item in source) {
                if (predicate.Invoke(item)) {
                    return true;
                }
            }
            return false;
        }
    }
}
