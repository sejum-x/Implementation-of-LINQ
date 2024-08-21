using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_LINQ {

    /// <summary>
    /// LINQ (Language-Integrated Query) - це інтегрована мова запитів, 
    /// яка надає простий та зручний спосіб запитів даних до джерела даних. 
    /// Джерелом даних може виступати будь-який об'єкт, 
    /// який реалізує інтерфейс IEnumerable (наприклад, стандартні колекції, масиви), 
    /// набір даних DataSet, XML-документ тощо. 
    /// Незалежно від типу джерела даних, LINQ дозволяє застосовувати один і той же підхід до вибірки даних.
    /// </summary>
    internal class Program {
        static void Main() {
            
            List<Employee> employees = new List<Employee>()
            {
                new Employee("Vasya", "Vasichkin", 20),
                new Employee("Peter", "Petrov", 32),
                new Employee("Oleksandr", "Kozynets", 39),
                new Employee("Ivan", "Ivanov", 25),
                new Employee("Ivan", "Dolmatov", 42)
            };

            // Where: фільтрує колекцію за певною умовою і повертає підмножину елементів,
            // які задовольняють цю умову.
            IEnumerable<Employee> olderPeople = employees.Where(emp => emp.Age > 20);

            // Select: вибирає певні поля з елементів колекції, щоб створити нову колекцію з вибраними полями.
            var shorteningPeople = employees.Select(emp => new {
                Name = emp.Name,
                birthYear = DateTime.Now.Year - emp.Age
            });

            // OrderBy / OrderByDescending: сортує елементи колекції відносно заданого поля
            // в порядку зростання або спадання.
            IEnumerable<Employee> orderedPeople = employees.OrderBy(emp => emp.Age);

            // Distinct: повертає унікальні елементи з колекції.
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> intsDistinct = ints.Distinct();

            // Any / All: перевіряє, чи є елементи в колекції,
            // які задовольняють певну умову (Any) або чи всі елементи колекції задовольняють цю умову (All).

            bool res = ints.Any();

            res = ints.All(arg => arg > 10);

            Console.ReadKey();
        }
    }

    class Employee {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Employee() {

        }

        public Employee(string name, string surname, int age) {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
