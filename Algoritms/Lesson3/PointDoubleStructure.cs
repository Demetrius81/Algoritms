﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson3
{
    /// <summary>
    /// Структура, содержащая координаты точки
    /// </summary>
    internal struct PointDoubleStructure
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