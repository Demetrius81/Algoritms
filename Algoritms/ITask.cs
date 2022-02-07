using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    interface ITask
    {
        /// <summary>
        /// Номер задачи
        /// </summary>
        string TaskNumber { get;}

        /// <summary>
        /// Название задачи
        /// </summary>
        string TaskName { get;}

        /// <summary>
        /// Вывод результатов работы
        /// </summary>
        void TaskResultOutput();
    }
}
