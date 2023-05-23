using ConsoleApp5;
using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Employee> people = new List<Employee>()
        {
            new Employee("Компьютеров Монитор Блокович", 1, 15300),
            new Employee("Миксеров Замес Тестович", 2, 15654),
            new Employee("Косяк Павел Александрович", 3, 16700),
            new Employee("Чайков Крик Ужасович", 4, 8499),
            new Employee("Махова Бабочка Крыльевна", 5, 5700),
            new Employee("Шевченко Макар Николаевич", 1, 5877),
            new Employee("Чашкин Сервиз Подаренович", 2, 29650),
            new Employee("Лучший Президент Путинович", 3, 3854),
            new Employee("Литвиненков Хасан Суетологович", 4, 2900),
            new Employee("Лилпипов Сурен Васарович", 5, 10000)
        };
        void test()
        {
            foreach (var emp in people)
            {
                Console.WriteLine($"{emp.FIO}");
            }
        }
        test();
        Console.ReadLine();
    }
}