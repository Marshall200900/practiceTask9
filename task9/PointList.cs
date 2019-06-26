using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public class PointList:IEnumerable<Point>
    {
        /// <summary>
        /// Размер циклического списка
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Первый элемент списка
        /// </summary>
        private Point Head { get;set ; }
        /// <summary>
        /// Последний элемент списка
        /// </summary>
        private Point Tail { get; set; }
        /// <summary>
        /// Конструктор
        /// </summary>
        public PointList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public void Add(Point p)
        {
            Count++;
            p.Next = Head;
            if (Head != null)
            {
                Tail.Next = p;
                Tail = p;
            }
            else
            {
                Head = Tail = p;
            }
        }
        /// <summary>
        /// Добавление элементов в циклический список. Каждый следующий элемент добавляется в конец
        /// </summary>
        /// <param name="val"></param>
        public void Add(int val)
        {
            Count++;
            Point point = new Point(val);
            point.Next = Head;
            if (Head != null)
            {
                Tail.Next = point;
                Tail = point;
            }
            else
            {
                Head = Tail = point;
            }
        }
        /// <summary>
        /// Удаление элемента по индексу
        /// </summary>
        /// <param name="index"></param>
        public void Delete(int index)
        {
            if (index < 0) return;
            Point point = Head;
            if (index == 0)
            {
                Head = Head.Next;
                point = Tail;
                point.Next = Head;
            }
            else
            {
                while (index != 1)
                {
                    point = point.Next;
                    index--;
                }
                point.Next = point.Next.Next;
            }
            Count--;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Find(Point p)
        {
            Point point = Head;
            int sizeTemp = Count;

            while (sizeTemp != 0)
            {
                if (p.Equals(point))
                {
                    return true;
                }
                point = point.Next;
                sizeTemp--;
            }
            return false;
        }
        public Point FindByIndex(int index)
        {
            if (index >= Count || index<0)
            {
                return null;
            }
            else
            {
                Point point = Head;
                int i = 0;
                while (i != Count)
                {
                    if (index == i)
                    {
                        return point;
                    }
                    point = point.Next;
                    i++;
                }
                return null;
            }
            
        } 
        /// <summary>
        /// Enumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            Point point = Head;
            int sizeTemp = Count;

            while (sizeTemp != 0)
            {
                yield return point.Number;
                point = point.Next;
                sizeTemp--;
            }
        }

        IEnumerator<Point> IEnumerable<Point>.GetEnumerator()
        {
            Point point = Head;
            int sizeTemp = Count;

            while (sizeTemp != 0)
            {
                yield return point;
                point = point.Next;
                sizeTemp--;
            }
        }
    }
}
