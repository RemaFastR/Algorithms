using System;
using System.Collections.Generic;
using Algorithms;

namespace Algotithms{
    public class Graph<T, N> : GraphBase<T, N>
    {
        public Graph(){
            Tops = new Dictionary<T, N>();
        }


    }
}