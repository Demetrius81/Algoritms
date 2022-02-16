using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson3
{
    /// <summary>
    /// Микросекундомер
    /// </summary>
    public class StopWatch
    {
        /// <summary>
        /// Поле начальное время
        /// </summary>
        private DateTime _timeStarted;

        /// <summary>
        /// Поле конечное время
        /// </summary>
        private DateTime _timeFinished;

        /// <summary>
        /// Поле время в микросекундах
        /// </summary>
        private double _time;

        /// <summary>
        /// Свойство поля начальное время
        /// </summary>
        private DateTime TimeStarted { get => _timeStarted; set => _timeStarted = value; }

        /// <summary>
        /// Свойство поля конечное время
        /// </summary>
        private DateTime TimeFinished { get => _timeFinished; set => _timeFinished = value; }

        /// <summary>
        /// Свойство поля время в микросекундах
        /// </summary>
        public double Time { get => _time; set => _time = value; }

        /// <summary>
        /// Запуск микросекундомера
        /// </summary>
        internal void Start()
        {
            TimeStarted = DateTime.UtcNow;
        }

        /// <summary>
        /// Остановка микросекундомера и расчет времени 
        /// </summary>
        internal void Stop()
        {
            TimeFinished = DateTime.UtcNow;

            TimeSpan deltaTime = TimeFinished - TimeStarted;

            Time = deltaTime.Ticks / 10;
        }
    }
}
