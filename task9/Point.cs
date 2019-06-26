using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public class Point
    {
        /// <summary>
        /// Значение текущего элемента
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Ссылка на следующий элемент
        /// </summary>
        public Point Next { get; set; }
        public Point(int number)
        {
            Number = number;
        }
    }
}
