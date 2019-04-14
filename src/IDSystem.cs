using System;
using System.Collections.Generic;

namespace SunceSlobode.Prototype
{
    /// <summary>
    /// Представляет систему управления нумерацией данных.
    /// </summary>
    public partial class IDSystem
    {
        /// <summary>
        /// Множество используемых номеров.
        /// </summary>
        protected SortedSet<int> occupied = new SortedSet<int>();

        private void DeleteHandler(int value)
        {
            occupied.Remove(value);
        }

        public IDSystem() { }

        /// <summary>
        /// Создает новый элемент нумерации данных.
        /// </summary>
        /// <returns>Новый элемент нумерации.</returns>
        /// <!--я вообще хз как это описывать надо нормально-->
        /// <!--с классом ID тоже самое-->
        public ID CreateID() => new SID(occupied.Max + 1, this, DeleteHandler);

        /// <summary>
        /// Создает новый элемент нумерации данных с заданным значением.
        /// </summary>
        /// <param name="value">Значение, которое будет использовано для создания элемента.</param>
        /// <returns>Новый элемент нумерации.</returns>
        /// <exception cref="InvalidOperationException">Требуемый номер уже используется.</exception>
        public ID CreateID(int value)
        {
            if (occupied.Contains(value))
                throw new InvalidOperationException("This value is occupied");

            return new SID(value, this, DeleteHandler);
        }
    }
}
