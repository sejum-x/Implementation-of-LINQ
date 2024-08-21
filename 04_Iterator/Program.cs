using System;
using System.Collections;
using System.Collections.Generic;

namespace _04_Iterator {
    /// <summary>
    /// IEnumerable та IEnumerator - це інтерфейси, які використовуються для 
    /// ітерації (перебору) колекцій в мові програмування C#.
    /// </summary>
    internal class Program {
        static void Main() {

            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Перебір коллекції з використанням циклу foreach
            foreach (var item in ints) {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));

            IEnumerable collections = (IEnumerable)ints;
            IEnumerator enumerator = collections.GetEnumerator();

            // Внутрішня реалізація циклу foreach
            while (enumerator.MoveNext()){
                object currentItem = enumerator.Current;
                Console.WriteLine(currentItem);
            }
        }
    }
}
