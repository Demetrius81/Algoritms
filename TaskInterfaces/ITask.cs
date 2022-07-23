using System;


namespace Algoritms
{
    public interface ITask
    {
        /// <summary>
        /// Номер задачи
        /// </summary>
        int TaskNumber { get; }

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
