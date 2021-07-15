using System;

namespace Algotithms
{
    ///<summary>
    /// Алгоритмы поиска
    ///</summary>
    public class SearchAlgorithms
    {
        ///<summary>
        /// Функция бинарного поиска.
        ///</summary>
        /// <param name="list">Входной массив чисел.</param>
        /// <param name="item">Число, которое нужно найти.</param>
        /// <returns>
        /// Индекс найденного элемента в массиве (если индекс -1, значит ничего не найдено).
        /// </returns> 
        public static int FindWithBinarySearch(int[] list, int item)
        {
            // Границы части списка, в котором выполняется поиск.
            int low = 0;
            int high = list.Length - 1;

            // Пока часть, где производится поиск не сократится до одного элемента.
            while (low <= high)
            {
                // Индекс среднего элемента.
                int mid = low + high;
                // Средний элемент.
                int guess = list[mid];

                // Проверяем средний элемент.
                if (guess == item)
                    // Возвращаем найденное значение.
                    return mid;
                // Много.
                if (guess > item)
                    high = mid - 1;
                // Мало.
                else
                    low = mid + 1;
            }

            // Значение не найдено.
            return -1;
        }
    }
}