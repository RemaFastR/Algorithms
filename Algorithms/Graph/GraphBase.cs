using System.Collections.Generic;

namespace Algorithms
{
    public abstract class GraphBase<T, N>
    {
        public Dictionary<T, N> Tops { get;set; }
        
        public void AddTop(T top, N neighbors){
            Tops.Add(top, neighbors);
        }
    }
}