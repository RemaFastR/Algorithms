using System;
using System.Collections;
using System.Collections.Generic;

namespace Algotithms
{
    public class Graph<T>
    {
        // Вершины графа представляем в виде хеш-таблицы 
        private Hashtable tops;
 
        public Graph(){
            tops = new Hashtable(); 
        }

        public Graph(Hashtable tops){
            this.tops = tops; 
        }

        ///<summary>
        /// Функция добавления узла в граф.
        ///</summary>
        /// <param name="top">Узел.</param>
        /// <param name="neighbors">Соседи.</param>
        /// <returns>
        /// 
        /// </returns> 
        public void AddTop(T top, List<T> neighbors){
            tops.Add(top, neighbors);
        }
    }
}