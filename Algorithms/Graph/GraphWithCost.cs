using System.Collections.Generic;
using Algotithms;

namespace Algorithms
{
    ///<summary>
    /// Реализация графа со стоимостями без ООП
    ///</summary>
    // Указываем что N - обязательно объект класса GraphItemWithCost<T, C>
    public class GraphWithCost<T, N, C> : GraphBase<T, N> where N: List<GraphItemWithCost<T, C>>
    {
         public GraphWithCost(){
            Tops = new Dictionary<T, N>();
        }
    }

    ///<summary>
    /// Реализация графа со стоимостями c ООП
    ///</summary>
    public class GraphWithCostOOP<T, N> : GraphBase<T, N>
    {
        public GraphWithCostOOP(){
            Tops = new Dictionary<T, N>();
        }
    }

    public class GraphItemWithCost<T, C>
    {
        public T Top { get; set; }
        public C Cost { get; set; }

        public GraphItemWithCost(T top, C cost){
            Top = top;
            Cost = cost;
        }
    }
}