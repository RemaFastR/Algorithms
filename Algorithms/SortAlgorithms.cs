using System.Collections.Generic;
using System.Linq;

namespace Algotithms
{
    public class SortAlgotithms
    {
        public static int[] SelectionSortBySmallest(int[] arr)
        {
            int min, temp;
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }

            return arr;
        }
    
        public static int[] QuickSort(int[] arr){
              
            // Базовый случай.
            if (arr.Length < 2)
                return arr;
            // Рекурсивный случай.
            else
            {
                // Опорный элемент.
                int pivot = arr[0];
                // Список элементов, меньших опорного.
                List<int> less = new List<int>();
                // Список элементов, больших опорного.
                List<int> greater = new List<int>();
                
                // Бежим по остальным элементам.
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] <= pivot)
                        less.Add(arr[i]);
                    else if (arr[i] > pivot)
                        greater.Add(arr[i]);
                }

                return QuickSort(less.ToArray()).Concat(new int[1]{pivot}).Concat(QuickSort(greater.ToArray())).ToArray();
            }
        }
    }

    public class AdditionalFunctions
    {
        public static int FindSmallest(int[] arr)
        {
            int min = arr[0];
            int minIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int CalculateArraySum(int[] arr, int i = 0){
            if (arr.Length <= i) 
                return 0; 
            else
                return arr[i] + CalculateArraySum(arr, i+1);
        }

        public static int GetArrayCount(int[] arr, int i = 0){
            if (arr.Length == i)
                return i;
            else
                return GetArrayCount(arr, i+1);
        }

        public static int GetMaxArrayValue(int[] arr, int i){
            if (i == 0)
                return arr[0];
            else{
                int max = GetMaxArrayValue(arr, i - 1);
                return max > arr[i-1] ? max : arr[i-1];
            }
        }
    }
}