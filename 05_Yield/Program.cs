using System.Collections;
using System;
using System.Collections.Generic;

namespace _05_Yield {

    /// <summary>
    /// Ітератор в С# - це блок коду, який використовує оператор yield для послідовного перебору значень набору
    /// </summary>
    internal class Program {
        static void Main() {
            List<int> ints = GetList();

            IEnumerable collections = (IEnumerable)ints;
            IEnumerator enumerator = collections.GetEnumerator();
            
            while (enumerator.MoveNext()) {
                object currentItem = enumerator.Current;
                Console.WriteLine(currentItem);
            }

            Console.WriteLine(new string('-', 30));

            IEnumerable<int> ints2 = GetEnumerator();

            IEnumerable collections1 = (IEnumerable)ints2;
            IEnumerator enumerator1 = collections1.GetEnumerator();

            while (enumerator1.MoveNext()) {
                object currentItem = enumerator1.Current;
                Console.WriteLine(currentItem);
            }

            Console.ReadKey();
        }

        public static List<int> GetList() {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++) {
                list.Add(i);
            }

            return list;
        }

        public static IEnumerable<int> GetEnumerator(){
            for (int i = 0; i < 10; i++) {
                yield return i;
            }
        }
    }
}
