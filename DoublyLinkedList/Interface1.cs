using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public interface ILinkedList
    {
        /// <summary>
        /// Возвращает количество элементов в списке
        /// </summary>
        /// <returns></returns>
        int GetCount();

        /// <summary>
        /// Добавляет новый элемент списка
        /// </summary>
        /// <param name="value"></param>
        void AddNode(int value);

        /// <summary>
        /// Добавляет новый элементсписка после определённого элемента
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        void AddNodeAfter(DoublyLinkedList node, int value);

        /// <summary>
        /// Удаляет элемент по порядковому номеру
        /// </summary>
        /// <param name="index"></param>
        void RemoveNode(int index);

        /// <summary>
        /// Удаляет указанный элемент
        /// </summary>
        /// <param name="node"></param>
        void RemoveNode(DoublyLinkedList node);

        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        DoublyLinkedList FindNode(int searchValue);
    }
}
