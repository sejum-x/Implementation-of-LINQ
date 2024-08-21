using System;

namespace _02_2.Concept_of_delegate {

    /// <summary>
    /// Дженериківський делегат (generic delegates) в С# - це делегат, 
    /// який може працювати з будь-яким типом даних, що передається як параметр. 
    /// Дженериківські делегати використовуються, коли потрібно передати метод, 
    /// який приймає та/або повертає певний тип даних, який може бути будь-яким.
    /// </summary>

    // Створення дженерівського классу делегату, який не приймае аргументів та не повертає значення.
    public delegate void Action();

    // Створення дженерівського классу делегату, який приймае один аргумент місця заповнення типу
    // та не повертає значення.
    public delegate void Action<T>(T arg);

    // Створення дженерівського классу делегату, який приймае два аргументи місця заповнення типу
    // та не повертає значення.
    public delegate void Action<T1, T2>(T1 arg1, T2 arg2);

    internal class Program {
        static void Main() {
            // Створення екземпляру дженерівського делегату Action та сполучення його з методом.
            Action action = new Action(Method1);

            // Або використовуючи техніку припущення делегату.
            action = Method1;

            // Або використовуючи лямбду. 
            action = () => Console.WriteLine("Method1");

            // Створення екземпляру дженерівського делегату Action<T> та сполучення його з методом.
            Action<int> action1 = new Action<int>(Method2);

            // Або використовуючи техніку припущення делегату.
            action1 = Method2;

            // Або використовуючи лямбду. 
            action1 = argument => { Console.WriteLine(string.Concat("Method1", argument)); };

            // Створення екземпляру дженерівського делегату Action<T1, T2> та сполучення його з методом.
            Action<int, string> action2 = new Action<int, string>(Method2);

            // Або використовуючи техніку припущення делегату.
            action2 = Method2;

            // Або використовуючи лямбду. 
            action2 = (argument1, argument2) => { Console.WriteLine(string.Concat("Method1", argument1, argument2)); };

            Console.ReadLine();
        }

        public static void Method1() {
            Console.WriteLine("Method1");
        }

        public static void Method2(int argument) {
            Console.WriteLine(string.Concat("Method1", argument));
        }
        public static void Method2(int argument1, string argument2) {
            Console.WriteLine(string.Concat("Method1", argument1, argument2));
        }
    }

}
