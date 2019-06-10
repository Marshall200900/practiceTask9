using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Inputs.Int("Введите размер циклического списка: ", 1);

            PointList pointList = new PointList();

            for (int i = 0; i < size; i++)
            {
                pointList.Add(Inputs.Int($"Введите {i+1}-й элемент списка: "));
            }

            Console.WriteLine("Элементы списка");
            foreach(int p in pointList)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine("");

            int index = Inputs.Int("Введите индекс удаляемого элемента: ", 0, pointList.Count-1);
            pointList.Delete(index);

            if(pointList.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            else
            {
                Console.WriteLine("Элементы списка");
                foreach (int p in pointList)
                {
                    Console.Write(p + " ");
                }
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
