using System;

namespace _02_Concept_of_delegate {
    /// <summary>
    /// Делегат в С# - це тип даних, який зберігає посилання на метод. 
    /// Тобто це вказівник на метод, також за допомогою делегата ми можемо викликати 
    /// метод, посилання на яке зберігає екземпляр делегата.
    /// 
    /// Делегати визначаються за допомогою ключового слова delegate, 
    /// після якого йде ім’я делегату, повертайме значення та список параметрів. 
    /// </summary>

    // Створення классу делегату, який не приймае аргументів та не повертає значення.
    public delegate void Action();

    // Створення классу делегату, який приймае аргумент та повертає значення.
    public delegate string Func(int a);

    // Створення классу делегату, який приймае аргумент та повертає значення.
    public delegate bool Predicate(int a);

    internal class Program {

        static void Main() {

            // Створення екземпляру делегату Action та сполучення його з методом SayHello.
            Action action = new Action(SayHello);

            // Выклик методу, який повязаний з екземпляром делегату.
            action.Invoke();
            action();

            // Створення екземпляру делегату Action та сполучення його з методом ConvertToString.
            Func func = new Func(ConvertToString);

            // Выклик методу, який повязаний з екземпляром делегату. 
            string result = func.Invoke(10);
            Console.WriteLine(result);
          
            result = func(10);
            Console.WriteLine(result);

            // Створення екземпляру делегату Predicate та сполучення його з методом CreateCondition.
            Predicate predicate = new Predicate(CreateCondition);

            // Або використовуючи техніку припущення делегату.
            predicate = CreateCondition;

            // Або використовуючи лямбда вираз замість методу CreateCondition. 
            predicate = argument => { return argument > 10; };

            // Можна передати екземпляр делегату в якості аргументу методу. 
            bool res = Compare(predicate, 20);
            Console.WriteLine(res); // true

            res = Compare(predicate, 5);
            Console.WriteLine(res); // false
            
            // Затримка
            Console.ReadLine();
        }

        public static bool Compare(Predicate predicate, int argument) {
            return predicate.Invoke(argument);
        }

        static bool CreateCondition(int argument) {
            return argument > 10;
        }

        static void SayHello() {
            Console.WriteLine("Say hello");
        }

        static string ConvertToString(int arg) {
            return arg.ToString();
        }
    }
}
