using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static int Int(string sentence, int minBorder = int.MinValue, int maxBorder = int.MaxValue)
        {
            int result = 0;
            bool ok = true;
            do
            {
                Console.Write(sentence);
                ok = int.TryParse(Console.ReadLine(), out result);
                if (result < minBorder || result > maxBorder)
                {
                    ok = false;
                }
            }
            while (!ok);
            return result;
        }
        public static void ListMenu()
        {
            Console.WriteLine("Задача №9. (10)\n" +
                "Напишите метод создания циклического списка, в информационные поля \n" +
                "элементов которого последовательно заносятся номера с 1 по N (N вводится с клавиатуры).\n");
            bool created = false;
            int answer;
            PointList list = new PointList();
            do
            {
                Console.WriteLine("" +
                    "1. Создать список\n" +
                    "2. Добавить элемент в список\n" +
                    "3. Удалить элемент из списка\n" +
                    "4. Поиск элемента по индексу\n" +
                    "5. Вывести список\n" +
                    "6. Выход" +
                    "");

                answer = Int("Введите номер: ",1, 6);
                switch (answer)
                {
                    case 1:
                        {
                            int size = Inputs.Int("Введите размер циклического списка: ", 1);
                            list = new PointList();
                            for (int i = 0; i < size; i++)
                            {
                                list.Add(Inputs.Int($"Введите {i+1}-й элемент списка: "));
                            }
                            Console.WriteLine("Список создан");
                            created = true;
                        }
                        break;
                    case 2:
                        {
                            if (!created)
                            {
                                list = new PointList();
                            }
                            list.Add(Inputs.Int($"Введите элемент списка: "));
                            Console.WriteLine("Элемент добавлен");
                            created = true;


                        }
                        break;
                    case 3:
                        {
                            if (created)
                            {
                                int number = Int("Введите номер элемента списка: ", 1, list.Count);
                                list.Delete(number-1);
                                Console.WriteLine("Элемент удален");
                                if (list.Count == 0)
                                    created = false;
                            }
                            else
                            {
                                Console.WriteLine("Список еще не создан");
                            }
                        }
                        break;
                    case 4:
                        {
                            if (created)
                            {
                                int number = Int("Введите номер элемента списка: ", 1, list.Count);
                                int res = list.FindByIndex(number-1).Number;
                                Console.WriteLine("Значение элемента: " + res);
                            }
                            else
                            {
                                Console.WriteLine("Список еще не создан");
                            }
                        }
                        break;
                    case 5:
                        {
                            
                            if (created)
                            {
                                Console.WriteLine("Элементы списка");
                                foreach (int p in list)
                                {
                                    Console.Write(p + " ");
                                }
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Список еще не создан");
                            }
                        }
                        break;

                }
            } while (answer < 6);
            
        }
        static void Main(string[] args)
        {
            ListMenu();
            
        }
    }
}
