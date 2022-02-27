using System;


namespace Algoritms
{
    public interface ITask
    {
        /// <summary>
        /// Номер задачи
        /// </summary>
        string TaskNumber { get; }

        /// <summary>
        /// Название задачи
        /// </summary>
        string TaskName { get; }

        /// <summary>
        /// Вывод результатов работы
        /// </summary>
        void TaskResultOutput();
    }
}
