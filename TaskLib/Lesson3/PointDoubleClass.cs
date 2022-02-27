using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    /// <summary>
    /// Класс, содержащий координаты точки
    /// </summary>
    internal class PointDoubleClass
    {
        /// <summary>
        /// Поле координата точки X
        /// </summary>
        private double _x;

        /// <summary>
        /// Поле координата точки Y
        /// </summary>
        private double _y;

        /// <summary>
        /// Свойство поля координата точки X
        /// </summary>
        public double X { get => _x; set => _x = value; }

        /// <summary>
        /// Свойство поля координата точки Y
        /// </summary>
        public double Y { get => _y; set => _y = value; } 
    }
}
