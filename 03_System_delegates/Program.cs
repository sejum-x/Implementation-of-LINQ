using System;

namespace _03_System_delegates {

    /// <summary>
    /// У .NET існує кілька вбудованих делегатів, які використовуються в різних ситуаціях. 
    /// Найбільш використовуваними із них, з якими часто доводиться стикатися, 
    /// є Action, Predicate та Func.
    /// </summary>
    internal class Program {
        static void Main()
        {
            // Action - це один з вбудованих делегатів в С#,
            // який не має повертати значення та може мати від 0 до 16 аргументів.
            // Даний делегат має кілька перевантажених версій: 

            // Створення дженерівського классу делегату Action. 
            Action<int> action = new Action<int>(Method);

            // Або використовуючи техніку припущення делегату.
            action = Method;

            // Або використовуючи лямбду. 
            action = argument => Console.WriteLine(argument);

            // Func - це один з вбудованих делегатів в С#,
            // який також може приймати від нуля до 16 аргументів і повертає значення визначеного типу.
            Func<int, int, int> func = new Func<int, int, int>(Summing);

            // Або використовуючи техніку припущення делегату.
            func = Summing;

            // Або використовуючи лямбду. 
            func = (arg1, rg2) => arg1 + rg2;

            // Predicate - це ще один вбудований делегат в С#, який приймає один параметр
            // і повертає значення типу bool.
            // redicate використовується для визначення методу,
            // який приймає об'єкт заданого типу і повертає значення true або false
            // в залежності від заданої логіки.
            Predicate<int> predicate = new Predicate<int>(Conditional);

            // Або використовуючи техніку припущення делегату.
            predicate = Conditional;

            // Або використовуючи лямбду. 
            predicate = argument => argument > 10;

        }

        static void Method(int argument) {
            Console.WriteLine(argument);
        }

        static int Summing(int arg1, int rg2) {
            return arg1 + rg2;
        }

        static bool Conditional(int argument) {
            return argument > 10;
        }
    }
}
