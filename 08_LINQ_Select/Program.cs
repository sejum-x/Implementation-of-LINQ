using System;
using System.Collections.Generic;

namespace _08_LINQ_Select
{
    internal class Program {
        static void Main() {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var res = ints.MySelect(element => element * 10);

            foreach (var item in res) {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    static class MyEnumerable {
        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector) { 
            foreach (TSource element in source) {
                yield return selector(element);
            }
        }
    }
}
