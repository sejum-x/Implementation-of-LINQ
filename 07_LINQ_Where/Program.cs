using System;
using System.Collections.Generic;

namespace _07_LINQ_Where {
    internal class Program {
        static void Main() {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var res = ints.MyWhere(t => t > 10);
        }
    }

    static class MyEnumerable {
        public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) {
            foreach (TSource item in source) {
                if (predicate.Invoke(item)) {
                    yield return item;
                }
            }
        }
    }
}
