using System;
using System.Collections.Generic;

namespace Tasker
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("--TASKER--");
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить задачу");
                Console.WriteLine("2. Показать все задачи");
                Console.WriteLine("3. Выход");
                Console.Write("> ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Введите название задачи: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Задача добавлена!");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("\nСписок задач:");
                    for (int i = 1; i <= tasks.Count; i++)
                    {
                        Console.WriteLine($"{i}. {tasks[i-1]}");
                    }
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод.");
                }
            }
        }
    }
}