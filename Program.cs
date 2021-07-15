using System;
using algo = Algotithms;

namespace ForAlgotithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[5] { 3, 5, -8, 22, 44};
         
            // Бинарный поиск.
            //Console.WriteLine(algo.SearchAlgorithms.FindWithBinarySearch(list, 22));
            
            // Сортировка выбором.
            // foreach (var item in algo.SortAlgotithms.SelectionSortBySmallest(list))
            // {
            //     Console.WriteLine(item);
            // }

            //Рекурсинавная функция расчета суммы элементов массива
            //Console.WriteLine(algo.AdditionalFunctions.CalculateArraySum(list));

            //Рекурсинавная функция подсчета количества элементов массива
            //Console.WriteLine(algo.AdditionalFunctions.GetArrayCount(list));

            //Рекурсивная функция нахождения максимального числа в массиве
            //Console.WriteLine(algo.AdditionalFunctions.GetMaxArrayValue(list, list.Length));
        
            // Быстрая сортировка с рекурсией
            foreach (var item in algo.SortAlgotithms.QuickSort(list))
            {
                Console.WriteLine(item);
            }
        }
    }
}
