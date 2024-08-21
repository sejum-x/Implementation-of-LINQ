using System;

namespace _01_ExtensionMethods {
    /// <summary>
    /// Методи розширення (Extension methods) - це статичні методи, 
    /// які дозволяють додатково розширювати функціональність класів без потреби наслідування, 
    /// змінення вихідного коду та створення нових класів. 
    /// 
    /// Методи розширення використовуються для додавання нових методів до існуючих типів даних, 
    /// включаючи стандартні типи даних(рядки або масиви) та користувацьких типів, 
    /// при цьому методи розширення можуть бути викликані як звичайні методи статичних класів, 
    /// що дозволяє зберігати звичайний синтаксис виклику методів.
    /// 
    /// Правила створення методів розширення:

    /// 1) Метод розширення повинен бути статичним методом, визначеним в статичному класі.
    /// 2) Параметр, до якого додається метод розширення, повинен бути позначений ключовим словом this.

    /// </summary>
    internal class Program {
        static void Main() {
            string variable = "Hello World";

            // Виклик методу Reverse як звичайного статичного методу.
            string reverseVariable = ExtensionMethods.Reverse(variable);
            Console.WriteLine(reverseVariable);

            // Виклик методу Reverse як методу розширення.
            reverseVariable = variable.Reverse();
            Console.WriteLine(reverseVariable);

            // Ланцюжок виклику методів без використання методів розширення. 
            string againVariable = ExtensionMethods.Reverse(ExtensionMethods.Reverse(variable));
            Console.WriteLine(againVariable);

            // Ланцюжок виклику методів з використанням методів розширення.
            againVariable = variable.Reverse().Reverse();
            Console.WriteLine(againVariable);

            // Можливість застовання методів розширення для користувацьких типів.
            Employee employee = new Employee()
            {
                Name = "Oleksandr",
                Surname = "Richter",
                Age = 30
            };

            // Виклик методу розширення як звичайного статичного методу для користувацького типу.
            int birthYear = ExtensionMethods.GetBirthYear(employee);
            Console.WriteLine(birthYear);

            // Виклик методу розширення  для користувацького типу.
            birthYear = employee.GetBirthYear();
            Console.WriteLine(birthYear);

            // Затримка
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Класс для зберігання методів розширення
    /// </summary>
    public static class ExtensionMethods {

        /// <summary>
        /// Метод розширення для string (рядка)
        /// </summary>
        public static string Reverse(this string input) {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Метод розширення для користувацького типу
        /// </summary>
        public static int GetBirthYear(this Employee input) {
            int currentYear = DateTime.Now.Year;
            return currentYear - input.Age;
        }
    }

    /// <summary>
    /// Звичайний користувацький класс
    /// </summary>
    public class Employee {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }
    }
}
