using System;
using System.Collections;
using System.Collections.Generic;
using Algotithms;
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
            // foreach (var item in algo.SortAlgotithms.QuickSort(list))
            // {
            //     Console.WriteLine(item);
            // }

            Graph<string> graph = new Graph<string>();
            graph.AddTop("you", new List<string>(){ "alice", "bob", "claire" });
            graph.AddTop("bob", new List<string>(){ "anju", "peggy" });
            graph.AddTop("alice", new List<string>(){ "peggy" });
            graph.AddTop("claire", new List<string>(){ "thom", "jonny" });
            graph.AddTop("anju", new List<string>(){ });
            graph.AddTop("peggy", new List<string>(){ });
            graph.AddTop("thom", new List<string>(){ });
            graph.AddTop("jonny", new List<string>(){ });
        }
    }
}
